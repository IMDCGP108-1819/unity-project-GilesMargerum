using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//This script gives holds the functions that are attributed to the buttons on the Instructions menu.
public class Return : MonoBehaviour {

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
