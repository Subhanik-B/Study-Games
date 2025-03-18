using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject door;
    public GameObject door2;

    public Vector3 doorPos = new Vector3();
    public Vector3 door2Pos = new Vector3();
    public GameObject player;
    void Start()
    {
        doorPos = door.transform.position;
        door2Pos = door2.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, door.transform.position) < 3.5)
        {
            if (door.transform.position.y < doorPos.y + 2) {
                door.transform.position = new Vector3(door.transform.position.x, door.transform.position.y + 0.01f, door.transform.position.z);
            }
            if (door2.transform.position.y < door2Pos.y + 2)
            {
                door2.transform.position = new Vector3(door2.transform.position.x, door2.transform.position.y + 0.01f, door2.transform.position.z);
            }
        }
        else
        {
            if (door.transform.position.y > doorPos.y)
            {
                door.transform.position = new Vector3(door.transform.position.x, door.transform.position.y - 0.01f, door.transform.position.z);
            }
            if (door2.transform.position.y > door2Pos.y)
            {
                door2.transform.position = new Vector3(door2.transform.position.x, door2.transform.position.y - 0.01f, door2.transform.position.z);
            }
        }
    }
}
