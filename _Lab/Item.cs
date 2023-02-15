using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Item", menuName= "Self/Item")]
public class Item : ScriptableObject
{
    // ----- variables --------------------------------------------------------
    public int id;
    public string itemName;
    [TextArea(4,4)]
    public string description;
    public int quantity;
    public int stackSize;
    public Sprite icon;

    // ----- methods ----------------------------------------------------------
    
    // public void Awake()
    // {
    //     id = 0;
    // }


}
