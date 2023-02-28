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
    public ItemData item;
    //public S_Inventory inventory;

    public static WorldItem SpawnItem(ItemData item, Vector3 position)
    {
        Transform obj = Instantiate(ItemAssets.Instance.pfItemWorld, position, Quaternion.identity);
        WorldItem worldItem = obj.GetComponent<WorldItem>();
        worldItem.item = item;
        worldItem.GetComponent<SpriteRenderer>().sprite = item.image;
        obj.localScale = new Vector3(obj.localScale.x, obj.localScale.y * .75f, obj.localScale.z);
        OnSpawn.Invoke(obj.GetComponent<WorldItem>());
        return worldItem;
    }

    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = item.image;
    }

    public void SetItem(ItemData item)
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
