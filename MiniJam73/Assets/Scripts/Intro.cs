using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    [SerializeField] Text text;
    [SerializeField] List<string> texts;
    [SerializeField] GameObject endButton;
    [SerializeField] string nextScenePath;
    int current;
    int total;

    private void Start()
    {
        total = texts.Count;
        current = 0;
        text.text = texts[0];
		AudioManager.Instance.Play("Intro");
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            current++;
            if (current < total)
            {
                text.text = texts[current];
            }
            else
            {
                text.text = "";
                endButton.SetActive(true);
            }
        }
    }

    public void CloseIntro()
    {
		AudioManager.Instance.GetAudioSource("intro").Stop();
        SceneManager.LoadScene(nextScenePath);
		AudioManager.Instance.PlayTheme();
    }
}
