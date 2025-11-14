using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item item; // Assign your Item ScriptableObject here in the Inspector

    public void PickUp()
    {
        // Add the item to the inventory manager
        Inventory_Manager.Instance.AddItem(item);

        // Destroy the object in the scene
        Destroy(gameObject);
    }
}