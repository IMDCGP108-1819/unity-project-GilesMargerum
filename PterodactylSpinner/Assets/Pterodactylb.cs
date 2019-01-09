using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Pterodactylb : MonoBehaviour
{
    // creating fields in the inspector for health and speed
    public int health = 3;
    public float speed;
    private Rigidbody2D rb;

    void Start()
    {

            rb = GetComponent<Rigidbody2D>();
            Vector2 movement = new Vector2(0.0f, -1);
            rb.AddForce(movement * speed);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();

            PterosRemaining.instance.count2 -= 1;

        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

}
