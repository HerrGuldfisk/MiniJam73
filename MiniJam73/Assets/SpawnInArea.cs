using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInArea : MonoBehaviour
{
    [SerializeField] GameObject spawnObject;
    [SerializeField] float secBetweenSpawn;
    float timer;

    private void Start()
    {
        timer = secBetweenSpawn;
        GetComponent<SpriteRenderer>().enabled = false;
    }

    void Spawn()
    {
        Vector2 pos;
        pos.x = Random.Range(transform.position.x - (transform.lossyScale.x/2), transform.position.x + (transform.lossyScale.x/2));
        pos.y = Random.Range(transform.position.y - (transform.lossyScale.y / 2), transform.position.y + (transform.lossyScale.y / 2));
        GameObject.Instantiate(spawnObject, pos, Quaternion.identity);
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            Spawn();
            timer = secBetweenSpawn;
        }
    }
}
