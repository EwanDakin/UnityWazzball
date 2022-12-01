using UnityEngine;

public class TrigScript : MonoBehaviour
{
    public GameObject uipanel;
    public GameObject player;
    public GameObject enemy;
    void Start()
    {
        uipanel.SetActive(false);
    }

    void OnTriggerEnter(Collider player)
    {
        Debug.Log("Enter");
        enemy.GetComponent<EnemyMovement>().look = true;
        uipanel.SetActive(true);
    }
}
