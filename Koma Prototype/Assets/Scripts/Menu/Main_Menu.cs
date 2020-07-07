﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    public AudioClip MainMusic;
    public void Start()
    {
        GetComponent<AudioSource>().PlayOneShot(MainMusic);

    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
