﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int health = 5;
    public int maxHealth = 9;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public void TakeEnemyDamage(int attackdamage)
    {
        health -= attackdamage;
    }
    void Start()
    {
        
    }
    void Update()
    {
        if (health > maxHealth)
            health = maxHealth;

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
                hearts[i].sprite = fullHeart;
            else
                hearts[i].sprite = emptyHeart;

            if (i < maxHealth)
                hearts[i].enabled = true;
            else
                hearts[i].enabled = false;
        }
        if (health <= 0)
        {
            int currentScene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentScene);
            health = 5;
        }      
    }
}
