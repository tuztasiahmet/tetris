using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerID : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnGUI () {
        foreach (Touch touch in Input.touches)
        {
            string text = "";
            text += "ID:" + touch.fingerId + "\n";
            text += "topCount:" + touch.tapCount + "\n";
            text += "phase:" + touch.phase.ToString() + "\n";
            text += "positonX:" + touch.position.x + "\n";
            text += "positionY:" + touch.position.y + "\n";
            int num = touch.fingerId;
            GUI.Label(new Rect(0+130 *num,0,120,100),text);
        }
	}
}
