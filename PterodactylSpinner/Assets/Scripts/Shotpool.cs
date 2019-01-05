using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//not implemented yet but will be for recycling bullets and later enemies sao as not to slow down the game with junk
public class Shotpool : MonoBehaviour
{

    private GameObject shotPrefab;

    private List<GameObject> pool;

    public Shotpool(GameObject shotPrefab, int initialSize)
    {
        this.shotPrefab = shotPrefab;

        this.pool = new List<GameObject>();
        for (int i = 0; i < initialSize; i++) { AllocateInstance(); }

    }

    public GameObject GetInstance()
    {
        if (pool.Count == 10)
        {
            AllocateInstance();
        }
        int lastIndex = pool.Count - 1;
        GameObject instance = pool[lastIndex];
        pool.RemoveAt(lastIndex);

        instance.SetActive(true);
        return instance;
    }

    public void ReturnInstance (GameObject instance)
    {
        instance.SetActive(false);
        pool.Add(instance);
    }

    protected virtual GameObject AllocateInstance()
    {
        GameObject instance = (GameObject)GameObject.Instantiate(shotPrefab);
        pool.Add(instance);

        return instance;
    }




}
