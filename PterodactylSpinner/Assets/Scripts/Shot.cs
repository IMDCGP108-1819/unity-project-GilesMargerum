using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Code for the bullet to travel when fired 

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
    // Deleting itself (currently) upon interacting with the Pterodactyl and dealing it damage.
    void OnTriggerEnter2D(Collider2D hitinfo)
    {
        Pterodactyl pterodactyl = hitinfo.GetComponent<Pterodactyl>();
        
            pterodactyl.TakeDamage(damage);
        
        Destroy(gameObject);

        Pterodactylb pterodactylb = hitinfo.GetComponent<Pterodactylb>();
        
            pterodactylb.TakeDamage(damage);
        
        Destroy(gameObject);
    }
}

