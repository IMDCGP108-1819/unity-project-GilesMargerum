using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firing : MonoBehaviour {

    public Transform firepoint;
    public GameObject shotPrefab;

    // code for shooting in each direction, altering the speed and axis depending on the button pressed.
    void Update() {
        if (Input.GetKeyDown(KeyCode.RightArrow)){
            GameObject go = (GameObject)Instantiate(shotPrefab, transform.position, Quaternion.identity);
            go.GetComponent<Shot>().xSpeed = 0.2f;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GameObject go = (GameObject)Instantiate(shotPrefab, transform.position, Quaternion.identity);
            go.GetComponent<Shot>().xSpeed = -0.2f;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GameObject go = (GameObject)Instantiate(shotPrefab, transform.position, Quaternion.identity);
            go.GetComponent<Shot>().ySpeed = 0.2f;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            GameObject go = (GameObject)Instantiate(shotPrefab, transform.position, Quaternion.identity);
            go.GetComponent<Shot>().ySpeed = -0.2f;
        }
    }
}
