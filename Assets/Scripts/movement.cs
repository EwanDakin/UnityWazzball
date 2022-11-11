using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 20;
    private Vector3 vmovement;

    void Update()
    {
        vmovement.x = Input.GetAxisRaw("Horizontal");
        vmovement.z = Input.GetAxisRaw("Vertical");
        if(vmovement.x != 0 && vmovement.z != 0)
        {
            vmovement *= 0.7f;
        }
        rb.velocity = vmovement * speed;
    }
}
