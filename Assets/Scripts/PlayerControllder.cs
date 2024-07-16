using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;


[System.Serializable]
public class Boundary
{
    [Header("边界控制")]
    public float xMin, xMax, zMin, zMax;
}


public abstract class PlayerControllerBase : MonoBehaviour
{
    [Header("炮弹预设体")]
    public GameObject bullet;
    [Header("移动速度")]
    public float Speed = 5f;
    public Boundary boundary;
    public float tilt = 4f;
    public Transform shotSpawn; // 炮弹发射点
    [Header("玩家开炮声音")]
    public AudioClip fireClip;

    protected Rigidbody rb;
    protected float fireRate = 0.2f; // 发射间隔
    protected float nextFire;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Init();
    }

    void Update()
    {
        HandleFire();
    }

    void FixedUpdate()
    {
        Move();
    }

    protected virtual void Init()
    {
        // 子类可重载的方法，用于初始化
    }

    protected abstract void Fire(); // 抽象方法，子类实现具体的射击方式

    private void HandleFire()
    {
        if (Input.GetButton("Fire") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Fire();
        }
    }

    private void Move()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.velocity = movement * Speed;

        // 飞机边界设置
        rb.position = new Vector3(
            Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
            0.0f,
            Mathf.Clamp(rb.position.z, boundary.zMin, boundary.zMax)
        );

        // 飞机侧身
        rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x * -tilt);
    }
}
