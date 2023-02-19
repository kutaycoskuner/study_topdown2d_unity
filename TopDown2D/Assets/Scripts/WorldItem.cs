using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WorldItem : MonoBehaviour, I_Pickup
{
    //public static event Action OnPickup;
    public EventInventoryPickup OnPickup = new EventInventoryPickup();
    public static EventWorldItemSpawn OnSpawn = new EventWorldItemSpawn();
    public Item item;
    //public S_Inventory inventory;

    public static WorldItem SpawnItem(Item item, Vector3 position)
    {
        Transform obj = Instantiate(ItemAssets.Instance.pfItemWorld, position, Quaternion.identity);
        WorldItem worldItem = obj.GetComponent<WorldItem>();
        obj.GetComponent<WorldItem>().item = item;
        obj.GetComponent<WorldItem>().GetComponent<SpriteRenderer>().sprite = item.image;
        OnSpawn.Invoke(obj.GetComponent<WorldItem>());
        return worldItem;
    }

    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = item.image;
    }

    public void SetItem(Item item)
    {
        this.item = item;
    }


    public void Pickup()
    {
        Debug.Log("You collected " + item.itemName + ".");
        //OnPickup?.Invoke();
        OnPickup.Invoke(item);
        //inventory.AddItem(item);
        Destroy(gameObject);
    }
}
