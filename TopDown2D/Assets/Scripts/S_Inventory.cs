using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class S_Inventory : MonoBehaviour
{
    public InventorySlot[] inventorySlots;
    public GameObject inventoryItemPrefab;

    //public static Item pickedItem;
    public static InventoryItem pickedInventoryItem;
    public static bool b_dropped = true;

    private void OnEnable()
    {
        WorldItem[] worldItems = FindObjectsOfType<WorldItem>();
        foreach (WorldItem worldItem in worldItems)
        {
            if (worldItem != null)
            {
                worldItem.OnPickup.AddListener(AddItem);
            }
        }
        WorldItem.OnSpawn.AddListener(SeekSub);
    }

    private void OnDisable()
    {
        WorldItem worldItem = FindObjectOfType<WorldItem>();
        if (worldItem != null)
        {
            worldItem.OnPickup.RemoveListener(AddItem);
        }
    }

    public void SeekSub(WorldItem worldItem)
    {
        if (worldItem != null)
        {
            worldItem.OnPickup.AddListener(AddItem);
        }
    }

    public void AddItem(Item item)
    {
        // check if any slot has the same item with count lower than max
        foreach (InventorySlot slot in inventorySlots)
        {
            InventoryItem itemInSlot = slot.GetComponentInChildren<InventoryItem>();
            if (itemInSlot == null || itemInSlot.item != item || itemInSlot.stack >= itemInSlot.item.stackSize) { continue; }
            itemInSlot.stack += 1;
            itemInSlot.UpdateStack();
            break;
            //return true;
        }

        // find empty slot
        foreach (InventorySlot slot in inventorySlots)
        {
            InventoryItem itemInSlot = slot.GetComponentInChildren<InventoryItem>();
            if (itemInSlot != null) { continue; }
            PlaceNewItem(item, slot);
            break;
            //return true;
        }
        //return false;
    }

    private void PlaceNewItem(Item item, InventorySlot slot)
    {
        GameObject newItemGO = Instantiate(inventoryItemPrefab, slot.transform);
        InventoryItem inventoryItem = newItemGO.GetComponent<InventoryItem>();
        inventoryItem.InitializeItem(item);
    }

    public static void DropItem(Vector3 position)
    {
        if (pickedInventoryItem == null) { return; }
        WorldItem.SpawnItem(pickedInventoryItem.item, position);
    }

    public void UseItem(Item item)
    {
    }
}
