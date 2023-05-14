using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] public float playerSpeed = 10f;
    [SerializeField] public Animator playerAnim;
    private CharacterController _controller;
    
    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        var aHorizontal = Input.GetAxis("Horizontal");
        var aVertical = Input.GetAxis("Vertical");
        var playerMovement = new Vector3(aHorizontal, 0f, aVertical);

        var isMoving = playerMovement != Vector3.zero; 
        if (isMoving)
        {
            playerAnim.SetFloat("Speed", 0.5f);
        }
        else
        {
            playerAnim.SetFloat("Speed", 0f);
        }

        _controller.Move(playerMovement * playerSpeed * Time.deltaTime);
        
    }
}
