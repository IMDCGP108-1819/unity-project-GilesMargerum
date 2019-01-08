using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreKeeping : MonoBehaviour
{

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

    void Start () {
        textMeshH = GetComponent<TextMeshProUGUI>();
        count = 0;
    }


    void Update()
    {
        textMeshH.text = "Fails " + count.ToString() + "/5";
    }

}
