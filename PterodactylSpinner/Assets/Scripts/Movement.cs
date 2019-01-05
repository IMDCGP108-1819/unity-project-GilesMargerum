using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Code for the player to control the chair using WASD

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private Vector2 direction;

    public Animator animator;

    private void Update()
    {
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

        if(Input.GetKeyUp(KeyCode.W))
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