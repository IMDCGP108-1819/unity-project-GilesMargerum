using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firing : MonoBehaviour {

    public Transform firepoint;
    public GameObject shotPrefab;

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown("d"))
        {
            Shoot();
        }
    }

    void Shoot ()
    {
        Instantiate(shotPrefab, firepoint.position, firepoint.rotation);
    }
	
}
