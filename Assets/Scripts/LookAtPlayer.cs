using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public bool look = false;
    void Start()
    {

    }

    bool Update()
    {
        if (look == true)
        {
            Debug.Log("Looking");
        }
        return look;
    }
}
