using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Car_Enemy_Controller : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject nav1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(nav1.transform.position);
    }
}
