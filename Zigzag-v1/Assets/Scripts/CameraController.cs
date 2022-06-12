using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform ballLocation;
    private Vector3 instance;
    void Start()
    {
        instance = transform.position - ballLocation.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(!BallController.isDown)
            transform.position = instance + ballLocation.position;
    }
}
