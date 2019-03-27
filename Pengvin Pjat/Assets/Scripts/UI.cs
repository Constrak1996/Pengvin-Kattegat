using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    // Field and property for the players health
    private int health = 3;
    public int Health { get => health; set => health = value; }

    //Field and property for the score
    private int score;
    public int Score { get => score; set => score = value; }

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
        if(Health <= 0)
        {
            
        }
    }
}
