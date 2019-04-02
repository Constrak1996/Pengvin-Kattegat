using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public AudioSource asource;
    public static bool soundMute;

    Text scoreText;

    public void Awake()
    {
        scoreText = GetComponent<Text>();
    }

    public void start()
    {
        asource = GetComponent<AudioSource>();
        soundMute = false;
    }
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    /// <summary>
    /// Method for sending the user to a new scene
    /// </summary>
    /// <param name="scene">0 is main menu, 1 is the game & 2 is deathscreen</param>
    public void ToNewScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void Update()
    {
        scoreText.text = "Highscore: " + Health.deathScore;
    }

    public void Mute()
    {
        asource.mute =! asource.mute;
        if(soundMute == false)
        {
            soundMute = true;
        }
        else
        {
            soundMute = true;
        }

    }
 
}
