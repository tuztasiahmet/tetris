using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMove : MonoBehaviour
{

    public float speed;

    // Use this for initialization
    void Start()
    {
        speed = 0.05f;
    }
    public void Update()
    {
        if (Input.touchCount == 1)
        {
            //transform.Translate(Input.touches[0].deltaPosition.x * speed, Input.touches[0].deltaPosition.y * speed, 0);
            //transform.position += new Vector3(Input.touches[0].deltaPosition.x / 100, 0, 0);
            //transform.position += new Vector3((Input.touches[0].deltaPosition.x /100) % Screen.width, 0, 0);
            string tempString = Input.touches[0].deltaPosition.x.ToString();
            int tempInt = Int32.Parse(tempString);

            if (tempInt < 0)
            {
                transform.position += new Vector3(-1, 0, 0);
            }
            else if (tempInt > 0)
            {
                transform.position += new Vector3(1, 0, 0);
            }
        }
    }
}
