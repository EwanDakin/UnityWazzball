using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public GameObject target1;
    public GameObject target2;
    Vector3 currentargetpos;
    Rigidbody rb;
    public float rotationspeed = 5f;
    public float enemyspeed = 5f;
    public bool look = false;
    public GameObject player;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 distance = (currentargetpos - transform.position).normalized * enemyspeed;
        rb.velocity = distance;
        if (Vector3.Distance(transform.position, target1.transform.position) <= 0.1)
        {
            currentargetpos = target2.transform.position;
        }
        else if (Vector3.Distance(transform.position, target2.transform.position) <= 0.1)
        {
            currentargetpos = target1.transform.position;
        }
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(distance), Time.deltaTime * rotationspeed);
            if (look == true)
        {
            Vector3 plocation = player.transform.position;
            Debug.DrawLine(this.transform.position, plocation, Color.red);
            transform.LookAt(player.transform);
        }
    }
}

