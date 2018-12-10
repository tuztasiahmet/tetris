using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basamak : MonoBehaviour {
    private Rigidbody2D basamak1;
	// Use this for initialization
	void Start () {
        basamak1 = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (orumcek.omcek == null && karakter.rigi != null)
        {
            basamak1.gravityScale = 10;
        }
    }
}
