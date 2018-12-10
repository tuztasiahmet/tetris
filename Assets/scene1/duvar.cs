using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class duvar : MonoBehaviour {
    Rigidbody2D duvar1;
    public float zeminY;
	// Use this for initialization
	void Start () {
        duvar1 = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if(karakter.rigi != null)
        {
            Vector2 duvar_pos = transform.position;
            Vector2 kar_pos = karakter.rigi.transform.position;
            if (kar_pos.x - 2 >= duvar_pos.x || duvar_pos.x <= kar_pos.x + 2)
            {
                if(karakter.rigi != null)
                {
                    duvar1.gravityScale = 10;
                }
            }
        }
        if(duvar1.transform.position.y < zeminY)
        {
            Destroy(gameObject);
        }
    }

}
