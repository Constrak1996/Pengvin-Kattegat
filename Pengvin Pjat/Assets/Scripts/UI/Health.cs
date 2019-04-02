using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
     
public class Health : MonoBehaviour
{
    // Field and property for the players health
    public static int health;
    //public int HealthPoints { get => health; set => health = value; }

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
        
        //if(HealthPoints <= 0)
        //{
            
        //}
    }
}
