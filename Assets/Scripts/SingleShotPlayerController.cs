using UnityEngine;

public class SingleShotPlayerController : PlayerControllerBase
{
    protected override void Fire()
    {
        Instantiate(bullet, shotSpawn.position, shotSpawn.rotation);
        AudioSource.PlayClipAtPoint(fireClip, transform.position);
    }
}