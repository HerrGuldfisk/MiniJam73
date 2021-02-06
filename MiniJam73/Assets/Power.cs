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

    float counter = 1;
    int power;

    private void Start()
    {
        endScreen.alpha = 0;
        power = startPower;
        SetBar();
    }

    public void AddPower(int powerChange)
    {
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
        endScreen.alpha = 1;
        endText.text = "win";
    }

    void Loose()
    {
        endScreen.alpha = 1;
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
