using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreKeeping : MonoBehaviour
{
    //This script checks how many Pterodactyls have connected with the grid.
    public static ScoreKeeping instance;

    private TextMeshProUGUI textMeshH;
    public int count;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    //The count begins at 0.
    void Start () {
        textMeshH = GetComponent<TextMeshProUGUI>();
        count = 0;
    }

    //If the number rises above 2 the script will transition the game to the "Game Over" screen.
    void Update()
    {
        textMeshH.text = "Fails " + count.ToString() + "/2";
        if (ScoreKeeping.instance.count >= 2)
        {
            SceneManager.LoadScene("Game Over");
        }
    }

}
