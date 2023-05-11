using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private NavMeshAgent enemy;
    [SerializeField] private Transform player;

    private void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        enemy.SetDestination(player.position);
    }
}
