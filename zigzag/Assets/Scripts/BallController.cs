using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    Vector3 navigation;
    public float speed;
    public float addSpeed;
    public FloorController floorController;
    public static bool isDown;
    void Start()
    {
        navigation = Vector3.forward;
    }

    void Update()
    {
        isDown = transform.position.y <= 0.5f;
        if (isDown)
        {
            return;
        }
        
        if (Input.GetMouseButtonDown(0)) // sol butona basılımca bir işlem yapsın
        {
            if (navigation.x == 0)
            {
                navigation = Vector3.left;
            }
            else
            {
                navigation = Vector3.forward;
            }

            speed += addSpeed * Time.deltaTime;
        }
    }

    private void FixedUpdate() // saniye başına daha fazla kontrol
    {
        Vector3 move = navigation * Time.deltaTime * speed;
        transform.position += move;
    }

    private void OnCollisionExit(Collision other) // zeminden ayrılınca yapılması gerekenler
    {
        if (string.Equals(other.gameObject.tag, "Floor"))
        {
            SkorController.skor++;
            other.gameObject.AddComponent<Rigidbody>();// objenin düşmesini sağlomak için
            floorController.CreateFloor();
            StartCoroutine(DeleteFloor(other.gameObject)); // belli bir süre sonra silinmesi için yazılan method
        }
    }

    IEnumerator DeleteFloor(GameObject floor)
    {
        yield return new WaitForSeconds(3f);
        Destroy(floor);
    }
}
