using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public AudioSource asource;
    public static bool soundMute;
    public Sprite soundOn;
    public Sprite soundOff;
    public Button muteButton;

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
        if (scene is 1)
        {
            PlayerMovement.slowed = false;
        }
        SceneManager.LoadScene(scene);
    }

    public void Mute()
    {
        asource.mute =! asource.mute;
        ChangeImage();
        if(soundMute == false)
        {
            soundMute = true;
        }
        else
        {
            soundMute = true;
        }
    }

    public void ChangeImage()
    {
        if(soundMute == false)
        {
            muteButton.image.sprite = soundOff;
        }
        else if(soundMute == true)
        {
            muteButton.image.sprite = soundOn;
        }
    }
}
