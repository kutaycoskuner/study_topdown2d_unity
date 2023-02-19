using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Scriptable Object/Item")]
public class Item : ScriptableObject
{
    [Header("Background")]
    public int id;

    [Header("Tooltip")]         // data displayed through window
    public string itemName;

    [Header("Gameplay and UI")]
    public Sprite image;
 
    [Header("Only gameplay")]
 
    [Header("Only UI")]
    [Range(1,400)]
    public int stackSize = 1; // default value 1

    // todo
    private enum ItemCategory
    {
        Equipable,
        Consumable,
        Placeable,
        Interactable,
        Material,
        Misc
    }

    private enum ActionType
    {

    }


}
