using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Document : MonoBehaviour
{
    public bool yesIsCorrect = true;
    string question;
    [SerializeField] Text textComp;

    private void Start()
    {
        transform.SetParent(GameObject.FindGameObjectWithTag("Paper Canvas").transform);
    }

    public void SetText(string _question)
    {
        question = _question;
        textComp.text = question;
    }

    public void setAnswer(bool _yesIsCorrect)
    {
        yesIsCorrect = _yesIsCorrect;
    }
}
