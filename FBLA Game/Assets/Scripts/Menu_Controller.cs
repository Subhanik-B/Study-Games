using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void beginGame()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void endGame()
    {
        Application.Quit();
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void helpScreen()
    {
        SceneManager.LoadScene("Help_Screen");
    }
}
