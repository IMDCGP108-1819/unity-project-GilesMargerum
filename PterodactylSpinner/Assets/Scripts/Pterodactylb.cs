using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Pterodactylb : MonoBehaviour
{
    // creating fields in the inspector for health, speed, rotation and slots to connect the script to an animation and a Rigidbody.
    public int health = 3;
    public float speed;
    public float rotationSpeed;
    private Animator animator;
    private Rigidbody2D rb;

    void Start()
    {
        //the code to cause the Pterodactyls to move downward
        rb = GetComponent<Rigidbody2D>();
        Vector2 movement = new Vector2(0.0f, -1);
        rb.AddForce(movement * speed);
    }
    void Update()
    {
        //The code to cause the Pterodactyls to spin
        transform.Rotate(0.0f, 1f, rotationSpeed);
    }
}
