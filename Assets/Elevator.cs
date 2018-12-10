using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour {

    Rigidbody2D elevator;
    public float hiz;
    public float durNoktasi;

	// Use this for initialization
	void Start () {
        elevator = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        elevator.transform.Translate(0, hiz * Time.deltaTime / 4, 0);
        Vector2 elevator_pos = transform.position;
    }
}
