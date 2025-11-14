using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    private ItemPickup itemInRange;

    void Update()
    {
        if (itemInRange != null && Input.GetKeyDown(KeyCode.E))
        {
            itemInRange.PickUp();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        ItemPickup pickup = other.GetComponent<ItemPickup>();
        if (pickup != null)
        {
            itemInRange = pickup;
            Debug.Log("Item in range: press E to pick up");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        ItemPickup pickup = other.GetComponent<ItemPickup>();
        if (pickup != null && itemInRange == pickup)
        {
            itemInRange = null;
        }
    }
}