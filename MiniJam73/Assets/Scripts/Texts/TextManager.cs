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

	private static TextManager _instance;
	public static TextManager Instance
	{
		get { return _instance; }
	}

	private void Awake()
	{
		if (_instance != null && _instance != this)
		{
			Destroy(this.gameObject);
			return;
		}

		_instance = this;
		DontDestroyOnLoad(this.gameObject);
	}

	// Start is called before the first frame update
	void Start()
    {
		firstName = Names.firstName;
		lastName = Names.lastName;

		numTexts = Texts.texts.Count;
	}

	public void CreateText(Document document)
	{
		int tempNumber = Random.Range(0, numTexts - 1);

		string tempText = Texts.texts[Random.Range(0, tempNumber)].text;
		int tempPoints = Texts.texts[Random.Range(0, tempNumber)].point;

		document.SetText(tempText);
		document.SetPoints(tempPoints);
	}
}
