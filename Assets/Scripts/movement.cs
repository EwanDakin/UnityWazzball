using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    //public Transform move;
    public float speed = 20;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey("w"))
        {
            //move.position += new Vector3(0, 0, 2);
            rb.AddForce(new Vector3(0, 0, speed));
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(new Vector3(-1 * speed, 0, 0));
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(new Vector3(speed, 0, 0));
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(new Vector3(0, 0, -1 * speed));
        }

        if (Input.GetKeyDown("left shift"))
        {
            speed = (float)(speed * 2);
        }
        if (Input.GetKeyUp("left shift"))
        {
            speed = (float)(speed / 2);
        }
    }
}
