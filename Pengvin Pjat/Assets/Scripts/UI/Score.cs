using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //Field and property for the score
    private int score;
    public int ScorePoints { get => score; set => score = value; }

    Text scoreText;
    /// <summary>
    /// Function called when program is launched
    /// </summary>
    void Awake()
    {
        scoreText = GetComponent<Text>();
        score = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score; " + score;
        
    }
}
