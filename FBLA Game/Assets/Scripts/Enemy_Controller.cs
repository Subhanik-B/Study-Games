using UnityEditor;
using UnityEngine;
using UnityEngine.AI;
public class Enemy_Controller : MonoBehaviour
{

    public GameObject player;
    public GameObject self;
    public float moveSpeed;
    public GameObject nav1;
    public GameObject nav2;
    public GameObject nav3;
    public GameObject nav4;
    public GameObject nav5;
    public bool nav5Done = false;
    public bool nav1Done = false;
    public bool nav2Done = false;
    public bool nav3Done = false;
    public bool nav4Done = false;
    public NavMeshAgent agent;
    public int distance = 5;
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
        }
        else if(!nav2Done)
        {
            agent.SetDestination(nav2.transform.position);
        }
        else if (!nav3)
        {
            agent.SetDestination(nav3.transform.position);
        }
        else
        {
            agent.SetDestination(nav1.transform.position);
        }

        if()
    }

    public void Jump()
    {
        self.transform.Translate(new Vector3(self.transform.position.x, self.transform.position.y + 0.25f, self.transform.position.y));
    }
}
