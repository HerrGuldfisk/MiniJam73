using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CursorMod : MonoBehaviour
{
    [SerializeField] Sprite openHand;
    [SerializeField] Sprite closedHand;
    [SerializeField] Image handImage;
    [HideInInspector] public bool handIsOpen;

    private void Awake()
    {
        handImage.sprite = openHand;
        handIsOpen = true;
    }

    void Update()
    {
        transform.position = Input.mousePosition;
        Cursor.visible = false;
    }

    public void SetHand(bool open)
    {
        if (open)
        {
            handImage.sprite = openHand;
        }
        else
        {
            handImage.sprite = closedHand;
        }
        handIsOpen = open;
    }
}
