using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pterodactyl : MonoBehaviour
{
    // creating feilds in the inspector for health and speed
    public int health = 3;
    public float speed = -0.1f;

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
