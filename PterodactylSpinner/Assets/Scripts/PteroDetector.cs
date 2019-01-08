﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PteroDetector : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Pterodactyl")
        {
            //add 1 point to the counter
            ScoreKeeping.instance.count += 1;
            // Destroying Pteros
            Destroy(collision.gameObject);
        }
    }

    // Use this for initialization
    void Start () {
		
	}

	// Update is called once per frame
	void Update () {
	
	}
   
}