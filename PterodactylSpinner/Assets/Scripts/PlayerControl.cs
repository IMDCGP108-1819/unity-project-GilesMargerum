using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl: MonoBehaviour
{

    public Transform firepoint;
    public GameObject shotPrefab;

    [SerializeField]
    private float speed;
    private Vector2 direction;

    public void Update()
    {
        //Firing up, left and right.
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
        //Update function to check if a move command has been made
        GetInput();
        Move();
    }

    // Keeping the Player in the grid
    private void LateUpdate()
    {
        float currentx = transform.position.x;
        float currenty = transform.position.y;

        // Left
        if (currentx < -2f)
        {
            transform.position = new Vector2(-2f, currenty);
        }

        //Right
        if (currentx > 2f)
        {
            transform.position = new Vector2(2f, currenty);
        }

        //Top
        if (currenty > 0.0f)
        {
            transform.position = new Vector2(currentx, 0.0f);
        }

        //Bottom
        if (currenty < -4f)
        {
            transform.position = new Vector2(currentx, -4f);
        }

    }
    //Functions to move the player in each direction. Speed set in the inspector window.
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
