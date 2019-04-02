﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    // Field and property for the players health
    public static int health;
    //public int HealthPoints { get => health; set => health = value; }
    public static int deathScore;

    Text healthText;

    /// <summary>
    /// Function called when program is launched
    /// </summary>
    void Awake()
    {
        healthText = GetComponent<Text>();
        health = 3;
    }

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {

    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        healthText.text = "Hp left:" + health;

        if (health <= 0)
        {
            Death();
        }
    }

    static public void Death()
    {
        deathScore = Score.score;
        SceneManager.LoadScene(2);
    }
}
