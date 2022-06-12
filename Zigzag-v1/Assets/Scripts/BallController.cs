using System;
using System.Collections;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Vector3 _navigation;
    public float speed;
    public float addSpeed;
    public FloorSpawner floorSpanner;
    public static bool isDown;
    void Start()
    {
        _navigation = Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        isDown = transform.position.y <= 0.5f;
        if (isDown || Input.touchCount < 1)
            return;

        Touch touch = Input.GetTouch(0);
        if (touch.phase == TouchPhase.Began)
        {
            if (_navigation.x == 0)
            {
                _navigation = Vector3.left;
            } else
            {
                _navigation = Vector3.forward;
            }

            speed += addSpeed * Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        transform.position += _navigation * Time.deltaTime * speed;
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag.Equals("Floor"))
        {
            SkorController.skor++;
            floorSpanner.CreateFloor();
            other.gameObject.AddComponent<Rigidbody>();
            StartCoroutine(DeleteFloor(other.gameObject));
        }
    }

    private IEnumerator DeleteFloor(GameObject floor)
    {
        yield return new WaitForSeconds(3);
        Destroy(floor);
    }
}
