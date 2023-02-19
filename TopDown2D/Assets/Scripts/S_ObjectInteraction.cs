using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_ObjectInteraction : MonoBehaviour
{
    public void HandlePlayerCollision(Collider2D collision)
    {
        I_Pickup item = collision.GetComponent<I_Pickup>();
        if (item == null) { return; }
        item.Pickup();
    }
}
