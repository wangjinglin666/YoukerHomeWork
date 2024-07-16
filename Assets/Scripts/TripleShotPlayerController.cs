using UnityEngine;

public class TripleShotPlayerController : PlayerControllerBase
{
    protected override void Fire()
    {
        Instantiate(bullet, shotSpawn.position, shotSpawn.rotation);
        Instantiate(bullet, shotSpawn.position + new Vector3(0.5f, 0, 0), shotSpawn.rotation * Quaternion.Euler(0, 0, 15));
        Instantiate(bullet, shotSpawn.position + new Vector3(-0.5f, 0, 0), shotSpawn.rotation * Quaternion.Euler(0, 0, -15));
        AudioSource.PlayClipAtPoint(fireClip, transform.position);
    }
}