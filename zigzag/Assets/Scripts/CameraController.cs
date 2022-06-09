using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform ballNavigation;
    private Vector3 distance;
    void Start()
    {
        distance = transform.position - ballNavigation.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(!BallController.isDown)
            transform.position = ballNavigation.position + distance;
    }
}
