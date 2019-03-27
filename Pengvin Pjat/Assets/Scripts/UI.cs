using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
     
public class UI : MonoBehaviour
{
    // Field and property for the players health
    private int health;
    public int Health { get => health; set => health = value; }

    //Field and property for the score
    private int score;
    public int Score { get => score; set => score = value; }

    Text scoreText;
    Text healthText;

    /// <summary>
    /// 
    /// </summary>
    void Awake()
    {
        scoreText = GetComponent<Text>();
        healthText = GetComponent<Text>();

        Score = 0;
        Health = 3;
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
        scoreText.text = "Score:" + Score;
        healthText.text = "Hp left:" + Health;        


        if(Health <= 0)
        {
            
        }
    }
}
