using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler
{
	public bool positive;
	[SerializeField] float feedbackTextTime = 3;
	[SerializeField] Text feedbackText;
	CursorMod cursor;

    private void Start()
    {
		feedbackText.text = "";
		if (GameObject.FindGameObjectWithTag("Cursor"))
		{
			cursor = GameObject.FindGameObjectWithTag("Cursor").GetComponent<CursorMod>();
		}
	}

	public void OnDrop(PointerEventData eventData)
	{
		Debug.Log("OnDrop");
		if ( eventData.pointerDrag != null)
		{
			eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
			Document doc = eventData.pointerDrag.GetComponent<Document>();

			if (feedbackText)
            {
				StartCoroutine(ShowFeedback(doc.points));
			}

			if (positive)
			{
				doc.RunEffect(positive);
			}
			else
			{
				doc.RunEffect(positive);
			}

			if (cursor)
			{
				cursor.ResetImagePos();
				cursor.SetHand(true);
			}
		}
	}

	IEnumerator ShowFeedback(int points)
    {
		feedbackText.text = points.ToString();

		yield return new WaitForSeconds(feedbackTextTime);

		feedbackText.text = "";
	}
}
