using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    public AudioSource asource;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(MainMenu.soundMute);
        asource = GetComponent<AudioSource>();
        if (MainMenu.soundMute == true)
        {
            Debug.Log("hello world");
            asource.volume = 0.0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
