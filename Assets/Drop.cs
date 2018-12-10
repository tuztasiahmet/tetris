using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour {
    public GameObject drop1;
    public GameObject drop2;
    public GameObject drop3;
    // Use this for initialization
    void Start () {
        //if (drop == null)
        //{
        //    drop = GameObject.FindWithTag("Drop");
        //}

        //Instantiate(respawnPrefab, respawn.transform.position, respawn.transform.rotation) ;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Instantiate(drop1,
                        new Vector3(karakter.rigi.transform.position.x, karakter.rigi.transform.position.y + 7, karakter.rigi.transform.position.z),
                        Quaternion.identity);
        }
        if (Input.GetKey(KeyCode.X))
        {
            Instantiate(drop2,
                        new Vector3(karakter.rigi.transform.position.x, karakter.rigi.transform.position.y + 7, karakter.rigi.transform.position.z),
                        Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Instantiate(drop3,
                        new Vector3(karakter.rigi.transform.position.x, karakter.rigi.transform.position.y + 7, karakter.rigi.transform.position.z),
                        Quaternion.identity);
        }


    }
}
