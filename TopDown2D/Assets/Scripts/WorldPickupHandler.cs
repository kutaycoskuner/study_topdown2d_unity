using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldPickupHandler : MonoBehaviour
{
    public void HandlePlayerCollision(Collider2D collision)
    {
        // if pick up pick
        I_Pickup item = collision.GetComponent<I_Pickup>();
        if (item == null) { return; }
        item.Pickup();

        // if gatherable gather

        // ...
    }
}
