using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public GameObject target1;
    public GameObject target2;
    public Vector3 currentargetpos;
    Rigidbody rb;
    public float rotationspeed = 5f;
    public float enemyspeed = 5f;
    public bool look = false;
    public GameObject player;
    Vector3 Lastknownpos;
    public float CooldownTimer = 3f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.position = target1.transform.position;
    }

    void Update()
    {
        Vector3 distance = (currentargetpos - transform.position).normalized * enemyspeed;
        rb.velocity = distance;
        Debug.DrawLine(transform.position, currentargetpos, Color.blue);
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
            Debug.DrawLine(transform.position, plocation, Color.red);
            transform.LookAt(player.transform);
            currentargetpos = player.transform.position;
            Lastknownpos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
            enemyspeed = 7.5f;
        }
        if (Vector3.Distance(transform.position, Lastknownpos) <= 1)
        {
            CooldownTimer -= Time.deltaTime;
            if (CooldownTimer <= 0)
            {
                currentargetpos = target1.transform.position;
                enemyspeed = 10f;
                CooldownTimer = 3f;
            }
        }
    }
}

