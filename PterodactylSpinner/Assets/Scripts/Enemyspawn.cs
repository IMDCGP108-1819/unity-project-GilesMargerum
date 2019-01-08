using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Code for spawning enemies

public class Enemyspawn : MonoBehaviour
{
    public GameObject Pterodactyl;
    public Vector2 spawnValues;

    void Start()
    {
        SpawnWaves();
    }

    void SpawnWaves()
    {
        Vector2 spawnPosition = new Vector2(spawnValues.x, spawnValues.y);
        Quaternion spawnRotation = Quaternion.identity;
        Instantiate(Pterodactyl, spawnPosition, spawnRotation);
    }
}