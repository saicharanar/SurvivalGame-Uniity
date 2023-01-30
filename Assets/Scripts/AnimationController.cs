using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{

    public Transform player;
    private Animator _animator;
    
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!player.transform.hasChanged)
        { 
            _animator.SetBool("Idle", true);
            return;
        }
        
        _animator.SetBool("Walk", true);
        _animator.SetBool("Idle", true);
        
    }
}
