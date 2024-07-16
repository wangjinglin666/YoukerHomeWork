using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class StartGame : MonoBehaviour
{
    //[Header("鼠标移入声效")]
   // public AudioClip _audioClip;
    private Button btn;
    private AudioSource audioSource;
    private  AudioClip clip;
    public Image SelectBg;

    private void OnEnable()
    {
        SelectBg.gameObject.SetActive(false);
    }

    private void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(OnClickStartGame);

    }
    private void OnClickStartGame()
    {
        //切换场景
       SelectBg.gameObject.SetActive(true);
        //SceneManager.LoadScene("Main");
    }

}
