using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Power : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] int maxPower = 100;
    [SerializeField] int startPower = 15;
    [SerializeField] CanvasGroup endScreen;
    [SerializeField] Text endText;
    [SerializeField] int powerLossPerSecond;

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
    public int power { get; private set; }

    private void Start()
    {
		endScreen.gameObject.SetActive(false);
        power = startPower;
        SetBar();
    }

    public void AddPower(int powerChange)
    {
		if (powerChange > 0)
		{
			AudioManager.Instance.Play("PowerIncrease");
		}
		else
		{
			AudioManager.Instance.Play("PowerDecrease");
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
		endScreen.gameObject.SetActive(true);
		endText.text = "win";
    }

    void Loose()
    {
		endScreen.gameObject.SetActive(true);
		endText.text = "defeat";
    }

    private void Update()
    {
        counter -= Time.deltaTime;
        if (counter <= 0)
        {
            AddPower(-powerLossPerSecond);
            counter = 1;
        }
    }
}
