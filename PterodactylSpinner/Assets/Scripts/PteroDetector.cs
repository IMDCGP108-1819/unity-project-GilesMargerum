using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PteroDetector : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //This script counts pterodactyls as they connect with the grid collider and passes that information to the ScoreKeeping script.
        if (collision.gameObject.CompareTag ("Pterodactyl")|| collision.gameObject.CompareTag ("Pterodactylb"))
        {
            //add 1 point to the counter
            ScoreKeeping.instance.count += 1;
            // Destroying Pterodactyls
            Destroy(collision.gameObject);
        }
    }
}
