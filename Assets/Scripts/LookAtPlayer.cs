using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public bool look = false;
    public GameObject player;

    void Update()
    {
        if (look == true)
        {
            Vector3 plocation = player.transform.position;
            Debug.DrawLine(this.transform.position, plocation, Color.red);
            transform.LookAt(player.transform);
        }
    }
}
