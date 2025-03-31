using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Level_2_Player_Movement : MonoBehaviour
{
    float horizontalInput;
    float verticalInput;
    public Transform orientation;
    public Vector3 moveDirection;
    public float moveSpeed;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        rb.transform.position += orientation.transform.forward * verticalInput * moveSpeed * Time.deltaTime;
        rb.rotation = Quaternion.Euler(rb.rotation.eulerAngles + new Vector3(0, (0.5f*horizontalInput), 0));
    }
}
