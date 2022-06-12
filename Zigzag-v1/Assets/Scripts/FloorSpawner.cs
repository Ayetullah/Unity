using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
    public GameObject lastFloor;
    void Start()
    {
        for (int i = 0; i < 25; i++)
        {
            CreateFloor();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateFloor()
    {
        Vector3 navigate;
        if(Random.Range(0,2) == 0)
            navigate = Vector3.left;
        else
            navigate = Vector3.forward;
        lastFloor = Instantiate(lastFloor, lastFloor.transform.position + navigate, lastFloor.transform.rotation);// Oluşturulan her zemin son zemine eşit olması için böyle bir şey yapıldı
    }
}
