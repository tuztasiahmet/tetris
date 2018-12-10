using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DalSarkar : MonoBehaviour {

    public static Rigidbody2D dal;
    float dalKartalDistance;
    float oldDalKartalDistance;
    // Use this for initialization
    void Start () {
        dal = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        dalKartalDistance = dal.transform.position.y - KartalKalkar.kartal.transform.position.y;
        if(oldDalKartalDistance - dalKartalDistance == 0)
        {

        }
        else
        {
            KartalKalkar.kartal.transform.Translate(0, dalKartalDistance, 0);
        }


    }
}
