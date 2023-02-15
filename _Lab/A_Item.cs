using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// [CreateAssetMenu(fileName="New Item", menuName= "Self/Item")]
public abstract class A_Item
{
    public int id;
    public int maxStack;
    public string itemName;
    [TextArea(4,4)]
    public string description;
    public GameObject prefab;


    // public int id;
    // public string itemName;
    // [TextArea(4, 4)]
    // public string description;
    // public int maxStackSize;
    // public GameObject prefab;

    // public Item(int id, string name, string description, GameObject prefab)
    // {
    //     this.id = id;
    //     this.name = itemName;
    //     this.description = description;
    //     this.prefab = prefab;
    //     // this.maxStackSize = maxStackSize;
    //     // this.icon = Resources.Load<Sprite>("Sprites/Items/" + name);
    // }

    // public Item(Item item)
    // {
    //     this.id = item.id;
    //     this.name = item.itemName;
    //     this.description = item.description;
    //     this.maxStackSize = item.maxStackSize;
    //     // this.icon = Resources.Load<Sprite>("Sprites/Items/" + name);
    // }

}
