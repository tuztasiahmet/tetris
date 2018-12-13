using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Click : MonoBehaviour {

    public static int tempRight;
    public static int tempLeft;
    public static int tempDown;
    public static int tempRotate;
    // Use this for initialization
    void Start () {
        tempRight = 0;
        tempLeft = 0;
        tempDown = 0;
        tempRotate = 0;
	}
	public void TouchRight()
    {
        tempRight++;
    }

    public void TouchLeft()
    {
        tempLeft++;
    }
    public void TouchDown()
    {
        tempDown++;
    }
    public void TouchRotate()
    {
        tempRotate++;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
