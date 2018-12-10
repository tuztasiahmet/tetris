using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour

{ 
    public float speed = 3;
    void Start ()
    {

    }
	
	// Update is called once per frame  
	void Update ()
    { // Distance moved = time * speed.
       

        if (gameObject.transform.position.x - 0.5 <= karakter.rigi.transform.position.x && gameObject.transform.position.x + 0.5 >= karakter.rigi.transform.position.x && karakter.rigi.transform.position.y -gameObject.transform.position.y < 0.6)
        {
            karakter.rigi.transform.Translate(0, speed, 0);
        }
	}
}
