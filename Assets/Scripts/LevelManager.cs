using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static bool GameisPaused = false;
    public GameObject exitMenu;

    public void LoadRequest(string name)
    {
        Debug.Log("Load request called for: " + name);
        Application.LoadLevel(name);
    }
    public void QuitRequest()
    {
        Debug.Log("Exit from the game! ");
        Application.Quit();
    }
    public void BackRequest(string name1)
    {
        Debug.Log("Back to Start Page!" + name1);
        Application.LoadLevel(name1);
    }

    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("Retry Button Accessed !");
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameisPaused)
            {
                ExitMenu();
            }
            else
            {
                Resume();
            }
        }
    }

    void ExitMenu()
    {
        exitMenu.SetActive(true);
        GameisPaused = true;
    }

    void Resume()
    {
        exitMenu.SetActive(false);
        GameisPaused = false;
    }
}
