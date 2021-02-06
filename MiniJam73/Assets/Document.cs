using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Document : MonoBehaviour
{
    public int points = 0;
    string question;
    [SerializeField] Text textComp;

    private void Start()
    {
        transform.SetParent(GameObject.FindGameObjectWithTag("Paper Canvas").transform);
		TextManager.Instance.CreateText(this);
    }

    public void SetText(string _question)
    {
        question = _question;
        textComp.text = question;
    }

    public void SetPoints(int _points)
    {
        points = _points;
    }

	public void RunEffect(bool positive)
	{
		Debug.Log("-" + points);
	}
}
