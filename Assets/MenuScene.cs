using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityEngine.UI;

public class MenuScene : MonoBehaviour {
    private VideoPlayer videoPlayer;
    public Button button;
    public Sprite play;
    public Sprite pause;

    void Awake()
    {
        button = GetComponent<Button>();
        videoPlayer = GetComponent<VideoPlayer>();
    }

    public void OyunEkrani()
    {
        SceneManager.LoadScene("scene14");
    }

    public void AnaMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
    public void PlayPause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            button.image.sprite = pause;
        }
        else
        {
            Time.timeScale = 1;
            button.image.sprite = play;
        }
    }


}
