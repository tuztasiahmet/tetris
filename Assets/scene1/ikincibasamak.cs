using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ikincibasamak : MonoBehaviour
{
    public Rigidbody2D ikinci_basamak;
    public Rigidbody2D ikinci_basamak2;
    Rigidbody2D zzz;
    // Use this for initialization
    void Start()
    {
        zzz = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
     
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "karakter")
        {
            ikinci_basamak.gravityScale = 10;
            ikinci_basamak2.gravityScale = 10;
        }
    }
}
