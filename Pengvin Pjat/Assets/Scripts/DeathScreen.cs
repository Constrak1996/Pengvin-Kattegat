using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathScreen : MonoBehaviour
{
    // Start is called before the first frame update

    Text scoreText;

    public void Awake()
    {
        scoreText = GetComponent<Text>();
    }

    public void Update()
    {
        scoreText.text = "Highscore: " + Health.deathScore;
    }
}
