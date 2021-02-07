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
		transform.SetParent(GameObject.FindGameObjectWithTag("Paper Canvas").transform);
		DocumentCounter.Instance.documents.Add(this.gameObject);
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
			AudioManager.Instance.Play("ApproveDocument");
			Power.Instance.AddPower(points);
		}
		else
		{
			AudioManager.Instance.Play("RejectDocument");
			Power.Instance.AddPower(-points);
		}

		DocumentCounter.Instance.documents.Remove(this.gameObject);
		Destroy(this.gameObject);
	}
}
