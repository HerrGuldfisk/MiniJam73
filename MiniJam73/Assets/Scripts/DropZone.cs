using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour
{
	public bool positive;
	[SerializeField] float feedbackTextTime = 3;
	[SerializeField] Text feedbackText;
	CursorMod cursor;
	[SerializeField] RectTransform rectTrans;
	GameManager manager;

    private void Start()
    {
		feedbackText.text = "";
		if (GameObject.FindGameObjectWithTag("Cursor"))
		{
			cursor = GameObject.FindGameObjectWithTag("Cursor").GetComponent<CursorMod>();
		}
		rectTrans = GetComponent<RectTransform>();

		if (GameObject.FindGameObjectWithTag("Manager"))
        {
			manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<GameManager>();
        }
	}

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
			if (manager.heldDoc)
            {
				Document doc = manager.heldDoc.GetComponent<Document>();
				if (rectOverlaps(doc.transform.GetChild(1).GetComponent<RectTransform>(), rectTrans))
				{
					if (feedbackText)
					{
						if (positive)
                        {
							StartCoroutine(ShowFeedback(doc.points));
						}
                        else
                        {
							StartCoroutine(ShowFeedback(-doc.points));
						}

					}

					doc.RunEffect(positive);

					if (cursor)
					{
						cursor.ResetImagePos();
						cursor.SetHand(true);
					}

					manager.heldDoc = null;
				}
			}
            else
            {
				Debug.Log("no document is being held");
            }
		}
    }

	IEnumerator ShowFeedback(int points)
    {
		feedbackText.text = points.ToString();

		yield return new WaitForSeconds(feedbackTextTime);

		feedbackText.text = "";
	}

	bool rectOverlaps(RectTransform rectTrans1, RectTransform rectTrans2)
	{
		Rect rect1 = new Rect(rectTrans1.position.x, rectTrans1.position.y, rectTrans1.rect.width, rectTrans1.rect.height);
		Rect rect2 = new Rect(rectTrans2.position.x, rectTrans2.position.y, rectTrans2.rect.width, rectTrans2.rect.height);

		Debug.Log("rect overlap: " + rect1.Overlaps(rect2));

		return rect1.Overlaps(rect2);
	}

}
