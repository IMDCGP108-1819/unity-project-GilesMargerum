using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PteroHealth : MonoBehaviour {

    public int health = 3;
    private Animator animator;

    //This function is used in the shot script and causes the damage animation to play and health to decrease
    //when a pterodactyl gets shot. It then checks health and if it is 0 it causes the enemy to be destroyed.
    public void TakeDamage(int damage)
    {
        health -= damage;
        
        if (health <= 0)
        {

            Death();

            PterosRemaining.instance.count2 -= 1;

        }

    }


    void Death()
    {
        Destroy(gameObject);
    }

}
