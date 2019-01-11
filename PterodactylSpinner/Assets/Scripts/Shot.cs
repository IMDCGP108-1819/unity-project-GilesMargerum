using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Code for the bullet to travel when fired and the damage it will deal to the Pterodactyls

public class Shot : MonoBehaviour
{
    public float ySpeed;
    public float xSpeed;
    public int damage = 1;
  
    void Update()
    {
        Vector2 position = transform.position;
        position.y += ySpeed;
        position.x += xSpeed;
        transform.position = position;  
    }
    // Deleting itself upon interacting with the Pterodactyl.
    //Causing the TakeDamage method to activate dealing damage and checking how many pterodactyls have been defeated
    void OnTriggerEnter2D(Collider2D hitinfo)
    {
        PteroHealth pterodactyl = hitinfo.GetComponent<PteroHealth>();
        if (pterodactyl != null)
        {
            pterodactyl.TakeDamage(damage);

            Destroy(gameObject);
        }
    }
}

