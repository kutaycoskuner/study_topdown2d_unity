using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    // ----- Variables --------------------------------------------------------
    public List<Item> items = new List<Item>();

    private void Awake()
    {
        BuildDatabase();
    }

    void BuildDatabase()
    {
        items = new List<Item>(
            // new Item(0, "Hand Axe", "This is a test item description.", , 1)
        );
    }
}
