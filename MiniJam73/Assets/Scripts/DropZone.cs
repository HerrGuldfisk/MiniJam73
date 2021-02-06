using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler
{
	public bool positive;

	public void OnDrop(PointerEventData eventData)
	{
		Debug.Log("OnDrop");
		if ( eventData.pointerDrag != null)
		{
			eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;

			if (positive)
			{
				// Add what happens whe the card is dropped.

				// eventData.pointerDrag...
			}
			else
			{
				// If a task is denied...
			}
		}
	}
}
