using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailGrid : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Shot"))
        {
            return;
        }

        Destroy(other.gameObject);
    }
}
