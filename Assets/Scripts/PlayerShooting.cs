using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private GameObject BulletPrefab;
    [SerializeField] private Transform BulletSpawn;

    [SerializeField] private float TimeBetweenShots = 0.3333f;
    private float _timeStamp = 0f;
    [SerializeField] private GunController _gunController;

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
        _gunController.FireWeapon();
        var bullet = Instantiate(BulletPrefab, BulletSpawn.position, BulletSpawn.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 50;
        Destroy(bullet, 2.0f);
    }
}
