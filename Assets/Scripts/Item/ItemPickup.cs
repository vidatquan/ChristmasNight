using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item Item;
    public Material material;
    public Material original;

    void Pickup()
    {
        InventoryManager.Instance.Add(Item);
        Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        Pickup();
        InventoryManager.Instance.ListItems();
    }

    private void OnMouseEnter()
    {
        GetComponent<MeshRenderer>().material = material;
    }
    private void OnMouseExit()
    {
        GetComponent<MeshRenderer>().material = original;
    }
}
