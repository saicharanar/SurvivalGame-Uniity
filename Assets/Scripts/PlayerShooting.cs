using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform BulletSpawn;

    public float TimeBetweenShots = 0.3333f;
    private float _timeStamp = 0f;

    void FixedUpdate ()
    {
        if((Time.time >= _timeStamp) && (Input.GetKey(KeyCode.Mouse0)))
        {
            Fire();
            _timeStamp = Time.time + TimeBetweenShots;
        }
    }

    void Fire()
    {
        var bullet = Instantiate(BulletPrefab, BulletSpawn.position, BulletSpawn.rotation);

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 50;

        // Destroy the bullet after 2 seconds
        Destroy(bullet, 2.0f);
    }
}
