using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] public float playerSpeed = 10f;
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

        var playerMoment = new Vector3(aHorizontal, 0f, aVertical);
        _controller.Move(playerMoment * playerSpeed * Time.deltaTime);
    }
}
