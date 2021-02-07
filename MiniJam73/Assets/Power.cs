using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Power : MonoBehaviour
{
    [SerializeField] Slider slider;

    [SerializeField] float maxPower = 100;
    [SerializeField] float startPower = 15;
    [SerializeField] float powerLossPerSecond;

    [SerializeField] string winScenePath;
    [SerializeField] string looseScenePath;

    private static Power _instance;
	public static Power Instance
	{
		get { return _instance; }
	}

	private void Awake()
	{
		if (_instance != null && _instance != this)
		{
			Destroy(this.gameObject);
			return;
		}

		_instance = this;
	}

	float counter = 1;

    public float power { get; private set; }

    private void Start()
    {
        power = startPower;
        SetBar();
    }

    public void AddPower(float powerChange, bool sound=true)
    {
		if (sound)
		{
			if (powerChange > 0)
			{
				AudioManager.Instance.Play("PowerIncrease");
			}
			else
			{
				AudioManager.Instance.Play("PowerDecrease");
			}
		}

        power += powerChange;

        if (power >= maxPower)
        {
            Win();
        }
        else if (power <= 0)
        {
            Loose();
        }

        SetBar();
    }

    void SetBar()
    {
        slider.value = (float)power / (float)maxPower;
    }

    void Win()
    {
        SceneManager.LoadScene(winScenePath);
        Playtime.running = false;
    }

    void Loose()
    {
		SceneManager.LoadScene(looseScenePath);
        Playtime.running = false;
    }

    private void Update()
    {
        counter -= Time.deltaTime;
        if (counter <= 0)
        {
            AddPower( -0.1f * DocumentCounter.Instance.documents.Count , false);
            counter = 1;
        }
    }
}
