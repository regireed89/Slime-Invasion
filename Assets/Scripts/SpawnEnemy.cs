using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform[] spawners;

    // Start is called before the first frame update
    void Start()
    {
        spawners = GetComponentsInChildren<Transform>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire2"))
        {
            Spawn();
        }
    }

    void Spawn()
    {
        int rand = Random.Range(0, spawners.Length);
        GameObject enemy = Instantiate(enemyPrefab, spawners[rand].position, Quaternion.identity);
    }
}
