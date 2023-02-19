using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Inventory : MonoBehaviour
{
    // ------------------------------------------------------------------------
    // ----- Variables --------------------------------------------------------
    // ------------------------------------------------------------------------
    private Inventory inventory;
    private Transform itemSlotContainer;
    private Transform itemSlotTemplate;

    public void SetInvetory(Inventory inventory)
    {
        this.inventory = inventory;
    }

    private void RefershInventoryItems() 
    {
        // int x = 0;
        // int y = 0;
        // float itemSLotCellSize = 30f;
        foreach (Item item in inventory.GetItemList())
        {
            // Debug.Log("Test" + item);
            // RectTransform itemSlotRectTransform = Instantiate(itemSlotTemplate, itemSlotContainer).GetComponent<RectTransform>();
            // itemSlotRectTransform.gameObject.setActive(true);
        }
    }
}
