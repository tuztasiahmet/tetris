using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartalKalkar : MonoBehaviour {

    public static Rigidbody2D kartal;
    float KartalDalDistance;
    // Use this for initialization
    void Start()
    {
        kartal = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //KartalDalDistance = DalSarkar.dal.transform.position.y - kartal.transform.position.y;

        //if (KartalDalDistance != 0)
        //{
        //    if (KartalDalDistance < 0)
        //    {
        //        DalSarkar.dal.transform.Translate(0, KartalDalDistance * -Time.deltaTime, 0);
        //    }
        //    if (KartalDalDistance > 0)
        //    {
        //        DalSarkar.dal.transform.Translate(0, KartalDalDistance * Time.deltaTime, 0);
        //    }
        //}

    }
}
