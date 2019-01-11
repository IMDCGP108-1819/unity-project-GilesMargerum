using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//This script gives holds the functions that are attributed to the buttons on the main menu.
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Level");
    }

    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void Quit()
    {
        Debug.Log ("Let Me Out!");
        Application.Quit();
    }
}
