using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddSound : MonoBehaviour
{
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Record()
    {
        if(!Microphone.IsRecording($"{Microphone.devices[0]}"))
        {
            audioSource.clip = Microphone.Start($"{Microphone.devices[0]}", true, 20, 44100);
            Debug.Log($"{Microphone.devices[0]} is recording");
        }
        else
        {
            Microphone.End($"{Microphone.devices[0]}");
            Debug.Log($"{Microphone.devices[0]} is stoped");
        }
    }
    public void Play()
    {
       if(!audioSource.isPlaying)
        {
            audioSource.Play();
            Debug.Log("Boton play activado");
        }
        else
        {
            audioSource.Stop();
            Debug.Log("Boton play desactivado");
        }
    }
}
