using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TumSesler : MonoBehaviour {

    public static bool silence = false;

    public Sprite play;
    public Sprite pause;
    public Button button;

    void AllSilence()
    {
        if (silence == false)
        {
            silence = true;
            button.image.sprite = pause;
        }
        else
        {
            silence = false;
            button.image.sprite = play;
        }
    }
}
