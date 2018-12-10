using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orumcek : MonoBehaviour {
    public static Rigidbody2D omcek;
    float hiz = 0;

    public float sol = 5;
    public float durNoktasi;
    // Use this for initialization
    void Start () {
        omcek = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if(omcek != null)
        {
            if (omcek.position.x < durNoktasi)
            {
                hiz = 0;
            }
        }
		//if(karakter.rigi == null)
  //      {
  //          Destroy(this.gameObject);
  //      }
        if (karakter.rigi != null)
        {
            Vector2 omcek_pos = transform.position;
            Vector2 kar_pos = karakter.rigi.transform.position;
            if (kar_pos.x - 3 >= omcek_pos.x || omcek_pos.x <= kar_pos.x + 3)
            {
                if (karakter.rigi != null)
                {
                    hiz = 1;
                }
            }
        }
        for (int i = 0; i < sol; i++)
        {
            transform.Translate(hiz * -Time.deltaTime / 4, 0, 0);
        }
      
    }
    //örümcekler üstüne zıplayarak öldürülecek. son örümcek aynı zamanda ağ fırlatacak.
}
