using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Document : MonoBehaviour
{
    public int points = 0;
    string question;
    [SerializeField] Text textComp;

	private void Awake()
	{
		transform.parent.SetParent(GameObject.FindGameObjectWithTag("Paper Canvas").transform);
		transform.parent.GetComponent<Canvas>().overrideSorting = true;
	}

	private void Start()
    {
		// worst line of code ever written.
		GetComponent<DragDrop>().canvas = transform.parent.GetComponent<Canvas>();
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
		if (positive)
		{
			Power.Instance.AddPower(points);
		}
		else
		{
			Power.Instance.AddPower(-points);
		}

		Destroy(this.gameObject);
	}
}
