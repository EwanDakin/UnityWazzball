using UnityEngine;

public class TrigScript : MonoBehaviour
{
    public GameObject uipanel;
    public GameObject player;
    void Start()
    {
        uipanel.SetActive(false);
    }
    void Update()
    {
 
    }

    public GameObject enemy;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter");
        enemy.GetComponent<EnemyMovement>().look = true;
        uipanel.SetActive(true);
        //player.GetComponent<movement>().speed = 0;
    }
}
