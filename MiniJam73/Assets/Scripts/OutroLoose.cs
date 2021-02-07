using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OutroLoose : MonoBehaviour
{
    [SerializeField] GameObject content;
    [SerializeField] string gameScenePath;

    private void Start()
    {
        StartCoroutine(ShowButtons());
        Cursor.visible = true;
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
