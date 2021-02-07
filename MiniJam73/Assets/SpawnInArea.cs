using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInArea : MonoBehaviour
{
    [SerializeField] GameObject spawnObject;
    [SerializeField] float secBetweenSpawn;
	[SerializeField] bool groupSpawn;

    float timer = 3;
	float totTime = 0;

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

        timer -= Time.deltaTime;
        if (timer < 0)
        {
			if (groupSpawn)
			{
				GroupSpawn();
			}
			else
			{
				Spawn();
			}

            timer = secBetweenSpawn;
        }
    }


	private void GroupSpawn()
	{
		int x = 0;

		// Number of documents based on time.
		if (totTime <= 10)
		{
			x = 4;
		}
		else if(totTime <= 120)
		{
			x = 6;
		}
		else if(totTime <= 180)
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
