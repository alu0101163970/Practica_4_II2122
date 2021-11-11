using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBeat : MonoBehaviour
{
    bool play = false;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        if(play == false)
        {
            audio.Play();
            play = true;
        }
        else
        {
            audio.Pause();
            play = false;
        }
    }
}
