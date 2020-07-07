﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_menu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;



    void Update()
    {
  if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
   public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
     
        
    }

    public void Upgrade()
    {
        pauseMenuUI.SetActive(false);
      
    }

   public void PauseBtn()
   {
       if (GameIsPaused)
       {
           Resume();
       }
       else
       {
           Pause();
       }
   } 
    public void BackFormUpgrade()
    {
        pauseMenuUI.SetActive(true);
      
    }


    void Pause()
    {
        pauseMenuUI.SetActive(true);
       
        Time.timeScale = 0f;
        GameIsPaused = true;

    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
    public void QuitGame()
    {
      
        Application.Quit();
    }


}
