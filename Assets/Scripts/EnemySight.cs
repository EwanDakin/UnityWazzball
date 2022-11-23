using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySight : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;
    float sus = 0;

    private void Start()
    {
        player.tag = "Player";
    }
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            while (sus <= 10)
            {
                sus += 0.1f * Time.deltaTime;
                Debug.Log(sus);
            }
            if (sus > 1f)
            { 
                enemy.GetComponent<EnemyMovement>().look = true;
                enemy.GetComponent<EnemyMovement>().enemyspeed = 0;
                player.GetComponent<movement>().speed = 0;
            }
        }
    }
}
