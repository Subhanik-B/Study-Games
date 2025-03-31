using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Camera_Rotation : MonoBehaviour
{
    [SerializeField] private Transform orientation;

    private float sensX = 4f;
    private float sensY = 4f;

    private Vector2 input;
    private Vector3 rotateValue;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        input.y = Input.GetAxis("Mouse X");
        input.x = Input.GetAxis("Mouse Y");

        rotateValue.x += input.x * sensX;
        rotateValue.y -= input.y * sensY;

        rotateValue.x = Mathf.Clamp(rotateValue.x, -90, 90);

        transform.rotation = Quaternion.Euler(-rotateValue.x, -rotateValue.y, 0);
        orientation.rotation = Quaternion.Euler(0, -rotateValue.y, 0);

        //transform.eulerAngles = transform.eulerAngles - rotateValue;
    }
}
