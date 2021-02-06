using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
	[SerializeField] private Canvas canvas;

	private RectTransform rectTransform;
	private CanvasGroup canvasGroup;

	private void Awake()
	{
		rectTransform = GetComponent<RectTransform>();
		canvasGroup = GetComponent<CanvasGroup>();
	}

	private void Start()
	{
		canvas = GetComponentInParent<Canvas>();
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
		canvas.sortingOrder = 15;
		canvasGroup.alpha = .8f;
		canvasGroup.blocksRaycasts = false;
	}

	public void OnDrag(PointerEventData eventData)
	{
		rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		canvas.sortingOrder = 10;
		canvasGroup.alpha = 1f;
		canvasGroup.blocksRaycasts = true;
	}

	public void OnPointerDown(PointerEventData eventData)
	{

	}

    // Update is called once per frame
    void Update()
    {

    }
}
