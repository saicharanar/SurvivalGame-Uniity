using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] public Animator playerAnim;
    [SerializeField] private GameObject BulletPrefab;
    [SerializeField] private Transform BulletSpawn;

    [SerializeField] private float TimeBetweenShots = 0.3333f;
    private float _timeStamp = 0f;
    // [SerializeField] private GunController _gunController;
    [SerializeField] private float BulletSpeed;

    void FixedUpdate ()
    {
        if((Time.time >= _timeStamp))
        {
            if ((Input.GetKey(KeyCode.Mouse0)) || (Input.GetKey(KeyCode.Space)))
            {
                Fire();
                playerAnim.SetFloat("Speed", 1f);
                _timeStamp = Time.time + TimeBetweenShots;
            }
        }
    }

    void Fire()
    {
        // _gunController.FireWeapon();
        var bullet = Instantiate(BulletPrefab, BulletSpawn.position, BulletSpawn.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * BulletSpeed;
        Destroy(bullet, 2.0f);
    }
}
