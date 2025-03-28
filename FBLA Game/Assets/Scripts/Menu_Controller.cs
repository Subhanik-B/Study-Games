using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu_Controller : MonoBehaviour
{
    public Button startButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        startButton.onClick.AddListener(beginGame);
    }

    public void beginGame()
    {
        SceneManager.LoadScene("Level_1");
    }
}
