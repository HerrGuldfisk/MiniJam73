using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
	public Canvas canvas;

	private RectTransform rectTransform;
	private CanvasGroup canvasGroup;
	CursorMod cursor;

	private void Awake()
	{
		rectTransform = GetComponent<RectTransform>();
		canvasGroup = GetComponent<CanvasGroup>();

		if (GameObject.FindGameObjectWithTag("Cursor"))
        {
			cursor = GameObject.FindGameObjectWithTag("Cursor").GetComponent<CursorMod>();
		}
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
		// Debug.Log("OnDrag");
		// canvas.sortingOrder = 15;
		canvasGroup.blocksRaycasts = false;

		if (cursor)
        {
			cursor.SetHand(false);
			cursor.SetImagePos((Vector2)transform.position + new Vector2(78, -400));
		}
	}

	public void OnDrag(PointerEventData eventData)
	{
		rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		// Debug.Log("EndDrag");
		AudioManager.Instance.Play("DropDocument");
		canvasGroup.blocksRaycasts = true;

		if (cursor)
        {
			cursor.SetHand(true);
			cursor.ResetImagePos();
		}
	}

	public void OnPointerDown(PointerEventData eventData)
	{
		// Debug.Log("Click");
		transform.SetAsLastSibling();
		AudioManager.Instance.Play("GrabDocument");
	}
}
