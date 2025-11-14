using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_Manager : MonoBehaviour
{
    
    //makes sure theres only one manager
    public static Inventory_Manager Instance;

    //the inventory
    public List<Item> items = new List<Item>();

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void AddItem(Item newItem)
    {
        items.Add(newItem);
        Debug.Log("Added item:" + newItem.itemName);
    }

    public void RemoveItem(Item item)
    {
        items.Remove(item);
        Debug.Log("Remove item:" + item.itemName);
    }
    
}
