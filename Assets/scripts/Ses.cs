using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ses : MonoBehaviour {

    public AudioSource audioData;

    public Sprite play;
    public Sprite pause;
    public Button button;

    public static bool music = true;
    public void Start()
    {
        if (!audioData.isPlaying)
        {
            audioData.Play();
        }
    }
    private void Update()
    {
        if (Boxes2.dondurme == true)
        {
            audioData.Play();
            Boxes2.dondurme = false;
        }
        
    }
    public void PlayPause()
    {
        if (audioData.isPlaying)
        {
            audioData.Pause();
            button.image.sprite = pause;
        }
        else
        {
            audioData.UnPause();
            button.image.sprite = play;
        }
    }
    public void Silence()
    {
        if(TumSesler.silence == false)
        {
            TumSesler.silence = true;
            button.image.sprite = pause;
        }
        else
        {
            TumSesler.silence = false;
            button.image.sprite = play;
        }
    }
}
