using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Random;

public class T_TestInsertation : MonoBehaviour
{
    public S_Inventory inventoryManager;
    public Item[] itemsToPickup;

    public void PickupItem() 
    {
        int rng = Random.Range(0, itemsToPickup.Length);
        Item item = itemsToPickup[rng];
        float rng1 = Random.Range(-0.9f, 0.9f);
        float rng2 = Random.Range(-0.9f, 0.9f);
        //WorldItem worldItem = WorldItem.SpawnItem( item , new Vector3(rng1, rng2));
        //
        //bool isAdded = inventoryManager.AddItem(item);
        //if (!isAdded) { 
        //    Debug.Log("No space available in your inventory.");
        //    return;
        //}
        //Debug.Log(item.itemName + " added to your inventory.");
    }
}
