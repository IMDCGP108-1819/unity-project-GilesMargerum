using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Pterodactyl : MonoBehaviour
{
    // creating fields in the inspector for health and speed
    public int health = 3;
    public float speed;
  


    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector2 movement = new Vector2(1, 0.0f);
        rb.AddForce(movement * speed);
    }
    // establishing how the Pterodactyl takes damage when it interacts with the shot
    // and then is destroyed once its health reaches zero
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }
    
    void Die()
    {
        Destroy(gameObject);
    }

}
