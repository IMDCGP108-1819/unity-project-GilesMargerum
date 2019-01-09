using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl: MonoBehaviour
{

    public Transform firepoint;
    public GameObject shotPrefab;
    public GameObject[] shotlist;
    public int MaxShots = 20;

    [SerializeField]
    private float speed;
    private Vector2 direction;

    public void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
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
        GetInput();
        Move();
    }

    void Move()
    {
        transform.Translate(direction * speed);
    }

    private void GetInput()
    {
        direction = Vector2.zero;

        if (Input.GetKeyUp(KeyCode.W))
        {

            direction += Vector2.up;

        }
        else if (Input.GetKeyUp(KeyCode.A))
        {

            direction += Vector2.left;

        }
        else if (Input.GetKeyUp(KeyCode.D))
        {

            direction += Vector2.right;

        }
        else if (Input.GetKeyUp(KeyCode.S))
        {

            direction += Vector2.down;

        }
    }
}
