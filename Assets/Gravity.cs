using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {

    public Rigidbody2D duvar2;
    // Use this for initialization
    void Start()
    {
        duvar2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (karakter.rigi != null)
        {
            Vector2 duvar_pos = transform.position;
            Vector2 kar_pos = karakter.rigi.transform.position;
            if (kar_pos.x - 2 >= duvar_pos.x || duvar_pos.x <= kar_pos.x + 2)
            {
                if (karakter.rigi != null)
                {
                    duvar2.gravityScale = 10;
                }
            }
        }
    }
}
