using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{

    public static bool isGamePaused = false;

    public GameObject UIMenu;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isGamePaused)
            {
                //Resume();
            }
            else
            {
                //Pause();
            }
        }
    }

    public void Resume()
    {

        isGamePaused = false;
        Time.timeScale = 1;
        UIMenu.SetActive(false);
    }

    public void pauseGame()
    {
        if (isGamePaused)
        {
            Resume();
        }
        else
        {
            isGamePaused = true;
            Time.timeScale = 0;
            UIMenu.SetActive(true);
        }
    }

    public void ResumeGame()
    {
        Resume();
    }
}
