using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    private Rigidbody2D rigi;
    public float spawn1SpotX;
    public float spawn1SpotY;
    public float spawn2SpotX;
    public float spawn2SpotY;
    public float spawn3SpotX;
    public float spawn3SpotY;
    // Use this for initialization
    void Start () {
        rigi = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "spawn1")
        {
            Instantiate(rigi, new Vector3(spawn1SpotX, spawn1SpotY, 0f), Quaternion.identity);
            Destroy(rigi.gameObject);
        }
        if (collision.gameObject.tag == "spawn2")
        {
            Instantiate(rigi, new Vector3(spawn2SpotX, spawn2SpotY, 0f), Quaternion.identity);
            Destroy(rigi.gameObject);
        }
        if (collision.gameObject.tag == "spawn3")
        {
            Instantiate(rigi, new Vector3(spawn3SpotX, spawn3SpotY, 0f), Quaternion.identity);
            Destroy(rigi.gameObject);
        }
    }
}
