using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShrinkBrain : MonoBehaviour
{
	float timer  = 1;
	Text textField;

	private void Start()
	{
		textField = GetComponent<Text>();
	}

	// Update is called once per frame
	void FixedUpdate()
    {
		timer -= Time.fixedDeltaTime;

		if(timer <= 0)
		{
			textField.text = "- " + (DocumentCounter.Instance.documents.Count / 10f).ToString();
		}
    }
}
