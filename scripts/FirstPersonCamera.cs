using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    // Start is called before the first frame updateç
    Transform player;
    void Start()
    {
        player = GameObject.Find("EthanGlasses").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + new Vector3(0,1.45f,0);
        transform.rotation = player.rotation;
    }
}
