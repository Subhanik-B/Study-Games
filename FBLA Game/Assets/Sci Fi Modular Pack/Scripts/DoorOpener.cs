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
    System.Random chance = new System.Random();
    int chanceHolder = new int();
    // Update is called once per frame
    void Update()
    {
        
        if (Vector3.Distance(monster.transform.position, door.transform.position) < 2 && chanceHolder == 2)
        {
            for (int i = 0; i < 10000; i++)
            {

            }
            door.transform.position = new Vector3(door.transform.position.x, door.transform.position.y + 0.0025f, door.transform.position.z);
            door2.transform.position = new Vector3(door2.transform.position.x, door2.transform.position.y + 0.0025f, door2.transform.position.z);
            openCloseDoor(true);
        }
        else
        {
            openCloseDoor(false);
        } 
    }

    public void openCloseDoor(Boolean m)
    {
        chanceHolder = chance.Next(1, 4);
        if (Vector3.Distance(player.transform.position, door.transform.position) < 3.5)
        {
            if (door.transform.position.y < doorPos.y + 2)
            {
                door.transform.position = new Vector3(door.transform.position.x, door.transform.position.y + 0.01f, door.transform.position.z);
            }
            if (door2.transform.position.y < door2Pos.y + 2)
            {
                door2.transform.position = new Vector3(door2.transform.position.x, door2.transform.position.y + 0.01f, door2.transform.position.z);
            }

        } else if (m)
        {

        }
        else
        {
            chanceHolder = chance.Next(1, 4);
            System.Random random = new System.Random();
            if (door.transform.position.y > doorPos.y)
            {
                int a = random.Next(1, 4);
                switch (a)
                {
                    case 2:
                        door.transform.position = new Vector3(door.transform.position.x, door.transform.position.y + 0.0025f, door.transform.position.z);
                        break;
                    default:
                        door.transform.position = new Vector3(door.transform.position.x, door.transform.position.y - 0.005f, door.transform.position.z);
                        break;
                }
            }
            if (door2.transform.position.y > door2Pos.y)
            {
                int a = random.Next(1, 4);
                switch (a)
                {
                    case 2:
                        door2.transform.position = new Vector3(door2.transform.position.x, door2.transform.position.y + 0.0025f, door2.transform.position.z);
                        break;
                    default:
                        door2.transform.position = new Vector3(door2.transform.position.x, door2.transform.position.y - 0.005f, door2.transform.position.z);
                        break;
                }
            }
        }
        
    }
}
