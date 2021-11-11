using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadOfEthan : MonoBehaviour
{
      Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("EthanGlasses").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + new Vector3(0,1.6f,0);
        transform.rotation = player.rotation;
        transform.Rotate(0,90,0);
    }
}
