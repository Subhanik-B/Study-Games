using UnityEngine;
using UnityEngine.AI;
public class Enemy_Controller : MonoBehaviour
{

    public GameObject player;
    public GameObject self;
    public float moveSpeed;
    public bool walk = true;
    public GameObject nav1;
    public GameObject nav2;
    public bool nav1Done = false;
    public bool nav2Done = false;
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
        
        if (Vector3.Distance(player.transform.position, self.transform.position) < distance)
        {
            agent.SetDestination(nav1.transform.position);
            distance = 15;
        }
        else
        {
            agent.SetDestination(player.transform.position);
            distance = 2;
        }
    }

    public void spawnLocation()
    {
        System.Random spawnpos = new System.Random();
        int numGenerated = spawnpos.Next(1, 4);
        switch (numGenerated)
        {
            case 1:
                self.transform.position = new Vector3(7.636f, 0.88f, -19.394f);
                break;
            case 2:
                self.transform.position = new Vector3(-9.25f, 0.88f, 19.394f);
                break;
            case 3:
                self.transform.position = new Vector3(0, 0.88f, -22.984f);
                break;
        }
    }
}
