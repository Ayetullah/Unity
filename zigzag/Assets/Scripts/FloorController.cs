using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class FloorController : MonoBehaviour
{
    public GameObject lastFloor;

    private void Start()
    {
        for (int i = 0; i < 30; i++)
        {
            CreateFloor();
        }
    }

    void Update()
    {
        
    }

    public void CreateFloor()
    {
        Vector3 navigation;

        #region Random yön belirleme
        if (Random.Range(0, 2) == 0)
        {
            navigation = Vector3.left;  
        } else
        {
            navigation = Vector3.forward;
        }
        #endregion

        lastFloor = Instantiate(lastFloor, lastFloor.transform.position + navigation, lastFloor.transform.rotation); // yeni zemin klonlama
    }
}
