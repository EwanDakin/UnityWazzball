using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EnemySight : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;
    float sus = 0;
    public float sustime = 10f;
    bool inCollider = false;
    public GameObject susbar;

    void Start()
    {
        player.tag = "Player";
    }
    void Update()
    {   
        if (inCollider)
        {   
            sus = Mathf.Clamp(sus + Time.deltaTime, 0f, sustime);
            enemy.GetComponent<EnemyMovement>().look = true;
            susbar.GetComponent<TextMeshProUGUI>().text = "susness = " + Mathf.Round(sus/sustime * 100) + "%";
            if (sus != 0f)
            {
                susbar.SetActive(true);
            }
        }
        else
        {
            sus = Mathf.Clamp(sus - Time.deltaTime, 0f, sustime);
            enemy.GetComponent<EnemyMovement>().look = false;
            susbar.GetComponent<TextMeshProUGUI>().text = "susness = " + Mathf.Round(sus / sustime * 100) + "%";
            if (sus == 0f)
            {
                susbar.SetActive(false);
            }
        }
        if (sus >= sustime)
        {
            player.GetComponent<movement>().speed = 0;
            enemy.GetComponent<EnemyMovement>().enemyspeed = 0;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inCollider = true; 
           
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inCollider = false;

        }
    }
}
