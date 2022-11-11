using UnityEngine;

public class TrigScript : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    public GameObject enemy;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter");

        newlook();

        void newlook()
        {
            //GameObject.AddComponent<LookAtPlayer>();
            enemy.GetComponent<LookAtPlayer>().look = true;
        }

    }
}
