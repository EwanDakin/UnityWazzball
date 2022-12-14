using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 20;
    private Vector3 vmovement;
    Vector3 PointerPosition;
    public GameObject torch;
    public GameObject torchtarget;

    void Update()
    {
        vmovement.x = Input.GetAxisRaw("Horizontal");
        vmovement.z = Input.GetAxisRaw("Vertical");
        if(vmovement.x != 0 && vmovement.z != 0)
        {
            vmovement *= 0.7f;
        }
        rb.velocity = vmovement * speed;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit))
        {
            torchtarget.transform.position = raycastHit.point;
        }
        torch.transform.LookAt(new Vector3(torchtarget.transform.position.x, 0f, torchtarget.transform.position.z));
    }

}
