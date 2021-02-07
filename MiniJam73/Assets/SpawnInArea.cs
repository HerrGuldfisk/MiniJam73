using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInArea : MonoBehaviour
{
    [SerializeField] GameObject spawnObject;

	[SerializeField] bool singleSpawn;
	[SerializeField] float singleSpawnTimer;
	[SerializeField] bool singleRandomized;

	[SerializeField] bool groupSpawn;
	[SerializeField] float groupSpawnTimer;
	[SerializeField] bool groupRandomized;

	[SerializeField] bool randomized;
	[SerializeField] float minRandom;
	[SerializeField] float maxRandom;

	float singleTimer;
	float groupTimer;
	float totTime = 0;

	[SerializeField] int shortGame = 45;
	[SerializeField] int mediumGame = 90;
	[SerializeField] int longGame = 135;
	[SerializeField] int extremeGame = 180;

    private void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }

    void Spawn()
    {
        Vector2 pos;
        pos.x = Random.Range(transform.position.x - (transform.lossyScale.x/ 2), transform.position.x + (transform.lossyScale.x/2));
        pos.y = Random.Range(transform.position.y - (transform.lossyScale.y / 2), transform.position.y + (transform.lossyScale.y / 2));
        GameObject.Instantiate(spawnObject, Camera.main.WorldToScreenPoint(pos), Quaternion.identity).transform.GetChild(0).transform.position = Camera.main.WorldToScreenPoint(pos);
    }

    private void Update()
    {
		totTime += Time.deltaTime;

		if (singleSpawn)
		{
			singleTimer -= Time.deltaTime;

			if (singleTimer <= 0)
			{
				Spawn();

				if (randomized)
				{
					singleTimer = Random.Range(singleSpawnTimer - minRandom, singleSpawnTimer + maxRandom);
				}
			}
		}

		if (singleSpawn)
		{
			groupTimer -= Time.deltaTime;

			if (groupTimer <= 0)
			{
				GroupSpawn();

				if (randomized)
				{
					groupTimer = Random.Range(groupSpawnTimer - minRandom, groupSpawnTimer + maxRandom);
				}
			}
		}


		/*
        singleTimer -= Time.deltaTime;
        if (singleTimer < 0)
        {
			if (groupSpawn)
			{
				GroupSpawn();
			}
			else
			{
				Spawn();
			}

            singleTimer = secBetweenSpawn;
        }*/
	}


	private void GroupSpawn()
	{
		int x = 0;

		// Number of documents based on time.
		if (totTime <= shortGame)
		{
			x = 4;
		}
		else if(totTime <= mediumGame)
		{
			x = 6;
		}
		else if(totTime <= longGame)
		{
			x = 8;
		}
		else if (totTime <= extremeGame)
		{
			x = 10;
		}

		AudioManager.Instance.Play("DealDocument");

		// The spwaning
		for (int i = 0; i < x; i++)
		{
			Spawn();

		}
	}


	public void Reset()
	{
		totTime = 0;
	}
}
