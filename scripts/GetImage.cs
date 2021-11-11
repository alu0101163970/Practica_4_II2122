using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetImage : MonoBehaviour
{
    WebCamTexture wc;
    // Start is called before the first frame update
    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        wc = new WebCamTexture($"{devices[0].name}");
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = wc;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayCamera()
    {
        if(!wc.isPlaying)
        {
            wc.Play();
            Debug.Log("Funciona");
        }
        else
        {
            wc.Pause();
        }
    }
}
