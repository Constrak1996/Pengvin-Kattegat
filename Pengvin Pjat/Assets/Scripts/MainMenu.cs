using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public AudioSource asource;
    public static bool soundMute;


    public void start()
    {
        asource = GetComponent<AudioSource>();
        soundMute = false;
    }
    // Start is called before the first frame update


    /// <summary>
    /// Method for sending the user to a new scene
    /// </summary>
    /// <param name="scene">0 is main menu, 1 is the game & 2 is deathscreen</param>
    public void ToNewScene(int scene)
    {
        SceneManager.LoadScene(scene);
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
