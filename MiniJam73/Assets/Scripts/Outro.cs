using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Outro : MonoBehaviour
{
    [SerializeField] Text text;
    [SerializeField] GameObject endButtons;
    [SerializeField] string introScenePath;
    [SerializeField] Image bg;
    [SerializeField] Color lightsOutColor;
    public int gameCompletionTime = 376;
    int current;
    int total;
    List<string> texts = new List<string>();

    private void Start()
    {
        AddStrings();
        total = texts.Count;
        current = 0;
        text.text = texts[0];
        Cursor.visible = true;
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
                bg.color = lightsOutColor;
                GetComponent<AudioSource>().Play();
                StartCoroutine(ShowButtons());
            }
        }
    }

    IEnumerator ShowButtons()
    {
        yield return new WaitForSeconds(3);
        endButtons.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(introScenePath);
    }

    public void Quit()
    {
        Application.Quit();
    }

    void AddStrings()
    {
        texts.Add("And so, my journey towards absolute world power has been completed");
        texts.Add("Noone can touch me now");
        texts.Add("I set the rules");
        texts.Add("I am the king of the world!");
        texts.Add("");
        texts.Add("It sure feels good");
        texts.Add("I can do whatever I want");
        texts.Add("");
        texts.Add("WHATEVER I want");
        texts.Add("");
        texts.Add("So...");
        texts.Add("...what do I want?");
        texts.Add("I mean, for all this time, my single goal has been to gain more power");
        texts.Add("But now, there is no more power to be gained");
        texts.Add("");
        texts.Add("huh...");
        texts.Add("");
        texts.Add("Well this sure is an awkward position to be in");
        texts.Add("I can get whatever I want");
        texts.Add("but I just dont know what that is");
        texts.Add("how do you even find out what you want?");
        texts.Add("what do other people want?");
        texts.Add("what should you want!?");
        texts.Add("");
        texts.Add("All these questions are making me tired");
        texts.Add("Well, its quiet late");
        texts.Add("After all, I have been sitting at this desk sorting papers for " + Mathf.Floor((float)gameCompletionTime/60)  +  " minutes and " + Mathf.Round(((((float)gameCompletionTime/60f)- Mathf.Floor((float)gameCompletionTime/60f)) * 60f)) + " seconds"); //ändra
        texts.Add("That is quite a long time");
        texts.Add("Decisions sure are tiring to make like this");
        texts.Add("I think i'll just take a shower and then go to bed");
        texts.Add("Maybe tomorrow I could bake some bread?");
        texts.Add("I have never had the time to try that");
        texts.Add("That would be nice");
        texts.Add("Well... good night then");
    }
}
