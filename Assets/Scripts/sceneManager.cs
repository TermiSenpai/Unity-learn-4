using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("playGame");
    }
    
    public void mainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
