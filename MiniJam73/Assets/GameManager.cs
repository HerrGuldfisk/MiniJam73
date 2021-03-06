using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject heldDoc;

	void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Restart();
        }
    }

    public void Restart()
    {
		DocumentCounter.Instance.documents.RemoveRange(0, DocumentCounter.Instance.documents.Count);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		AudioManager.Instance.Play("MainTheme");
		AudioManager.Instance.tickTock = true;
    }
}
