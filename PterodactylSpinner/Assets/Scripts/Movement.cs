using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

        if(Input.GetKeyUp(KeyCode.UpArrow))
        {

            direction += Vector2.up;

        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {

            direction += Vector2.left;

        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {

            direction += Vector2.right;

        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {

            direction += Vector2.down;

        }
    }
}