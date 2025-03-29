using UnityEngine;

public class Enemy_Controller : MonoBehaviour
{

    public GameObject player;
    public GameObject self;
    public float moveSpeed;
    public bool walk = true;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetDirection = player.transform.position;
        Vector3 newPostition = Vector3.MoveTowards(self.transform.position, targetDirection, moveSpeed * Time.deltaTime);
        self.transform.position = newPostition;
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
