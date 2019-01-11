using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PterosRemaining : MonoBehaviour

{
    //This script checks how many Pterodactyls have been destroyed by shooting.

    public static PterosRemaining instance;

    private TextMeshProUGUI textMeshH;
    public int count2;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        textMeshH = GetComponent<TextMeshProUGUI>();
        count2 = 3;
    }

    //if the counter reaches 0 it changes scene to the win screen.
    void Update()
    {
        textMeshH.text = "Pterodactyls Unspun " + count2.ToString();
        if (PterosRemaining.instance.count2 <= 0)
        {
            SceneManager.LoadScene("Win Screen");
        }
    }


}
