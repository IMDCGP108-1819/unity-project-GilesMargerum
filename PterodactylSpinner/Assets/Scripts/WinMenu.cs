using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//This script gives holds the functions that are attributed to the buttons on the Win and Game Over menus.
public class WinMenu : MonoBehaviour {

    public void PlayAgain()
    {
        SceneManager.LoadScene("Level");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void Quit()
    {
        Debug.Log("Let Me Out!");
        Application.Quit();
    }
}
