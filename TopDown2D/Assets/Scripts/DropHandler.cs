using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropHandler : MonoBehaviour, IDropHandler
{
    public Camera mainCamera;
    public GameObject player;

    void Start()
    {
        // Get the main camera
        mainCamera = Camera.main;
    }

    public void OnDrop(PointerEventData eventData)
    {
        Vector3 dropPosition = GetWorldCursorWorldPosition();
        //Debug.Log(dropPosition);
        InventoryItem.parentAfterDrag = null;
        S_Inventory.DropItem(dropPosition);

    }

    private float CalcDropPositionFromPlayer()
    {
        return 0.0f;
    }

    private Vector3 GetWorldCursorWorldPosition()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 worldPos = mainCamera.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 5.0f));
        return worldPos;
    }
}
