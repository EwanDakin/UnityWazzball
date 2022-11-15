using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float camheight= 7;
    void Start()
    {
        
    }

    void Update()
    {
        var posx = GameObject.Find("player").transform.position.x;
        var posz = GameObject.Find("player").transform.position.z;
        transform.position = new Vector3(posx,camheight,posz);
    }
}
