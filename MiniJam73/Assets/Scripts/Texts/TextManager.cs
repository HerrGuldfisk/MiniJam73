using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextManager : MonoBehaviour
{

	public List<string> firstName;
	public List<string> lastName;

	// Start is called before the first frame update
	void Start()
    {
		firstName = Names.firstName;
		lastName = Names.lastName;
	}

	public void CreateText()
	{
		/*
		int totTexts = Texts.texts.Count;

		Random.Range(0, )

		TextAlignment = Texts.texts.Count*/
	}
}
