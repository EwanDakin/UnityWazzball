using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyArea : MonoBehaviour
{
    public GameObject enemy;
    void Start()
    {
        enemy.tag = "Enemy";
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            enemy.GetComponent<EnemySight>().looklock = false;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Leave");
            enemy.GetComponent<EnemyMovement>().currentargetpos = enemy.GetComponent<EnemyMovement>().target1.transform.position;
            enemy.GetComponent<EnemySight>().looklock = true;
        }

    }

}
