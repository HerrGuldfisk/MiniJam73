using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OutroLoose : MonoBehaviour
{
    [SerializeField] GameObject content;
    [SerializeField] Text text;
    [SerializeField] string gameScenePath;

    private void Start()
    {
        StartCoroutine(ShowButtons());
        Cursor.visible = true;
        float gameCompletionTime = Playtime.playtime;
        text.text = "You precidency ended after " + Mathf.Floor(gameCompletionTime / 60) + " minutes and " + Mathf.Round((((gameCompletionTime / 60f) - Mathf.Floor(gameCompletionTime / 60f)) * 60f)) + " seconds";
    }

    IEnumerator ShowButtons()
    {
        yield return new WaitForSeconds(3);
        content.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(gameScenePath);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
