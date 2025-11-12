using UnityEngine;

public class InventoryTest :MonoBehaviour
{
    public Item testItem;

    void Start()
    {
        Inventory_Manager.Instance.AddItem(testItem);
    }
    
}
