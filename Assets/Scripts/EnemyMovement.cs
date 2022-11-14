using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public static Vector3 Destination = new Vector3 ((float) 0.0, (float) 0.5, (float) -2.5);
    public static Vector3 Start = new Vector3((float)0.0, (float)0.5, (float)-12.5);
    public float enemyspeed = 2;
    public bool look = false;
    public GameObject player;

    void Update()
    {
        if (Destination != Start)
        {
            Vector3.MoveTowards(Start,Destination,enemyspeed);
        }
        if (look == true)
        {
            Vector3 plocation = player.transform.position;
            Debug.DrawLine(this.transform.position, plocation, Color.red);
            transform.LookAt(player.transform);
        }
    }
}

