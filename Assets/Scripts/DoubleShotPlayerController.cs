using UnityEngine;

public class DoubleShotPlayerController : PlayerControllerBase
{
    protected override void Fire()
    {
        Instantiate(bullet, shotSpawn.position + new Vector3(0.5f, 0, 0), shotSpawn.rotation);
        Instantiate(bullet, shotSpawn.position + new Vector3(-0.5f, 0, 0), shotSpawn.rotation);
        AudioSource.PlayClipAtPoint(fireClip, transform.position);
    }
}