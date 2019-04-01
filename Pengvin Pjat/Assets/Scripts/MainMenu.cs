using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public void StartGame()
    {
        SceneManager.LoadScene(1);
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
