using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    [SerializeField] private Slider healthBar; 
    private float TimeBetweenDamage = 5f;
    private float _timeStamp = 0f;
    private float damage = 5f;
    private void Start()
    {
        Debug.Log("script added");
    }

    private void OnCollisionEnter(Collision collision)
    {
        var isEnemy = collision.gameObject.tag.Equals("Enemy");
        if (isEnemy)
        {
            healthBar.value -= damage;
        }
    }

    private void OnCollisionStay(Collision collisionInfo)
    {
        var isEnemy = collisionInfo.gameObject.tag.Equals("Enemy");
        var damageable = Time.time >= _timeStamp;
        
        if(isEnemy && damageable)
        {
            healthBar.value -= damage;
            _timeStamp = Time.time + TimeBetweenDamage;
        }
    }
    
}
