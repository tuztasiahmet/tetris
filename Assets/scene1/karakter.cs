//ikinci basamak düşünce ölmesi için kod yaz.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakter : MonoBehaviour {

    public float hiz = 5;
    public float ziplama_hizi = 30;
    public static Rigidbody2D rigi;
    
    // Use this for initialization
    void Start()
    {
        rigi = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.tag == "duvar")
        //{
        //    Destroy(rigi.gameObject);
        //}
        //if(collision.gameObject.tag == "omcek")
        //{
        //    Destroy(rigi.gameObject);
        //}
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Vector2 yon = transform.localScale;
            yon.x *= 1;

            if (yon.x > 0)
            {
                transform.localScale = yon;
            }
            transform.Translate(hiz * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Vector2 yon = transform.localScale;
            yon.x *= 1;
            if (yon.x < 0)
            {
                transform.localScale = yon;
            }
            transform.Translate(hiz * -Time.deltaTime, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(0, ziplama_hizi * Time.deltaTime, 0);
        }

    }
   
}
