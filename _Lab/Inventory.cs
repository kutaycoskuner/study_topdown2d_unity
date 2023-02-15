using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<Item> itemList;

    public Inventory()
    {
        itemList = new List<Item>();
        GenerateTestItems();
    }

    public void GenerateTestItems()
    {
        AddItem(new Item { itemName = "Potato" });
        AddItem(new Item { itemName = "Water" });
        AddItem(new Item { itemName = "Pot" });
        Debug.Log("Inventory has " + itemList.Count + " items");
    }

    public void AddItem(Item item)
    {
        itemList.Add(item);
    }

    public void DropItem(Item item)
    {
        itemList.Remove(item);
        // generate item on position
    }

    public void UseItem(Item item)
    {
        // do soemthing with the item
    }    



    public List<Item> GetItemList() 
    {
        return itemList;
    }
}
