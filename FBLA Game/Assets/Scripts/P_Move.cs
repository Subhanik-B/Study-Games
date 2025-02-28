using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Rigidbody rb;
    // Update is called once per frame
    void Update()
    {
        Vector3 bob = new Vector3();
        bob.x = Input.GetAxis("Horizontal");
        bob.z = Input.GetAxis("Vertical");
        rb.Move(bob, rb.rotation);
    }
}
