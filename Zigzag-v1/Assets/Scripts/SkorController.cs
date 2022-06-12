using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkorController : MonoBehaviour
{
    public static int skor;
    public Text skorTxt;
    void Start()
    {
        skor = 0;
    }

    // Update is called once per frame
    void Update()
    {
        skorTxt.text = skor.ToString();
    }
}
