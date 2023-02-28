using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class InventoryItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{


    [Header("UI")]
    public Image image;
    public TextMeshProUGUI stackDisplay;
    // [HideInInspector] public Item item;
    public ItemData item;
    [HideInInspector] public int stack = 1;
    [HideInInspector] public static Transform parentAfterDrag;

    private void Start()
    {
        InitializeItem(item);
    }

    public void InitializeItem(ItemData newItem)
    {
        item = newItem;
        image.sprite = newItem.image;
        UpdateStack();
    }

    public void UpdateStack()
    {
        stackDisplay.text = stack.ToString();
        bool b_textActive = stack > 1;
        stackDisplay.gameObject.SetActive(b_textActive);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        //Debug.Log(this.item.itemName);
        Inventory.pickedInventoryItem = this;
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData evetData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (parentAfterDrag == null)
        {
            Destroy(gameObject);
        }
        else
        {
            transform.SetParent(parentAfterDrag);
            image.raycastTarget = true;
        }
        Inventory.pickedInventoryItem = null;
    }
}


