using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;
public class Enemy_Controller : MonoBehaviour
{

    public GameObject player;
    public GameObject self;
    public Rigidbody Rself;
    public float moveSpeed;
    public GameObject nav1;
    public GameObject nav2;
    public GameObject nav3;
    public GameObject nav4;
    public GameObject nav5;
    public GameObject nav6;
    public bool nav5Done = false;
    public bool nav1Done = false;
    public bool nav2Done = false;
    public bool nav3Done = false;
    public bool nav4Done = false;
    public bool nav6Done = false;
    public NavMeshAgent agent;
    public int distance = 5;
    public Vector3 selfChecker;
    public float JumpForce = 4f;
    public Vector3 currentNav;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!nav1Done)
        {
            agent.SetDestination(nav1.transform.position);
            if(Vector3.Distance(nav1.transform.position, self.transform.position) < 1)
            {
                nav1Done = true;
            }
        }
        else if (!nav6Done)
        {
            agent.SetDestination(nav6.transform.position);
            if (Vector3.Distance(nav6.transform.position, self.transform.position) < 1)
            {
                nav6Done = true;
            }
        }
        else if (!nav2Done)
        {
            agent.SetDestination(nav2.transform.position);
            if (Vector3.Distance(nav2.transform.position, self.transform.position) < 1)
            {
                nav2Done = true;
            }
        }
        else if (!nav3Done)
        {
            agent.SetDestination(nav3.transform.position);
            if (Vector3.Distance(nav3.transform.position, self.transform.position) < 1)
            {
                nav3Done = true;
            }
        }
        else if (!nav4Done)
        {
            agent.SetDestination(nav4.transform.position);
            if (Vector3.Distance(nav4.transform.position, self.transform.position) < 1)
            {
                nav4Done = true;
            }
        }
        else if (!nav5Done)
        {
            agent.SetDestination(nav5.transform.position);
            if (Vector3.Distance(nav5.transform.position, self.transform.position) < 1)
            {
                nav5Done = true;
            }
        }
        else
        {
            agent.SetDestination(nav6.transform.position);
        }
            currentNav = agent.destination;
    }

    public void Jump()
    {
        Rself.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
    }
}
