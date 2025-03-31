using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject door;
    public GameObject door2;

    public Vector3 doorPos = new Vector3();
    public Vector3 door2Pos = new Vector3();
    public GameObject player;
    public GameObject monster;
    void Start()
    {
        doorPos = door.transform.position;
        door2Pos = door2.transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        
        if (Vector3.Distance(monster.transform.position, door.transform.position) < 3 || Vector3.Distance(player.transform.position, door.transform.position) < 5)
        {
            for (int i = 0; i < 10000; i++)
            {

            }
            door.transform.position = new Vector3(door.transform.position.x, door.transform.position.y + 0.0095f, door.transform.position.z);
            door2.transform.position = new Vector3(door2.transform.position.x, door2.transform.position.y + 0.0095f, door2.transform.position.z);
        }
        else if (door.transform.position.y > doorPos.y)
        {
            for (int i = 0; i < 10000; i++)
            {

            }
            door.transform.position = new Vector3(door.transform.position.x, door.transform.position.y - 0.0055f, door.transform.position.z);
            door2.transform.position = new Vector3(door2.transform.position.x, door2.transform.position.y - 0.0055f, door2.transform.position.z);
            
        }
    }

    
}
