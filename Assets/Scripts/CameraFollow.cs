using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    private float _camOffsetZ;
    private Vector3 _cameraCurrentPos;
    void Start()
    {
        _cameraCurrentPos = GetComponent<Transform>().position;
        _camOffsetZ = _cameraCurrentPos.z;
    }

    // Update is called once per frame
    void Update()
    {
        var playerPosition = player.position;
        var cameraPos = new Vector3(playerPosition.x, _cameraCurrentPos.y, playerPosition.z + _camOffsetZ);

        gameObject.transform.position = cameraPos;
    }
}
