using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkorController : MonoBehaviour
{
    // Start is called before the first frame update
    public static int skor;
    public Text skorText; 
    void Start()
    {
        skor = 0;
    }

    // Update is called once per frame
    void Update()
    {
        skorText.text = skor.ToString();
    }
}
