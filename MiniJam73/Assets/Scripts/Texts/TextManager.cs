using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextManager : MonoBehaviour
{

	public List<string> firstName;
	public List<string> lastName;

	private int numTexts;

	public GameObject document;

	// Start is called before the first frame update
	void Start()
    {
		firstName = Names.firstName;
		lastName = Names.lastName;

		numTexts = Texts.texts.Count;
	}

	public void CreateText()
	{
		string tempText = Texts.texts[Random.Range(0, numTexts - 1)].text;
		int points = Texts.texts[Random.Range(0, numTexts - 1)].point;

		Instantiate(document, transform).GetComponent<Document>().SetText(tempText);
	}
}
