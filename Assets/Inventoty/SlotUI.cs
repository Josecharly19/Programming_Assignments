using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotUI : MonoBehaviour
{
    public GameObject slotPrefab; //visual slot empty
    public Transform gridPanel; //the panel with gridlayourgrpup

    private List<GameObject> slots = new List<GameObject>();
    private const int totalSlots = 24; //10x6 grid

    private void Start()
    {
        GenerateSlots();
        RefreshInventory();
    }
    //creates 60 empty UI slots
    public void GenerateSlots()
    {
        //clear.old slots
        foreach (Transform child in gridPanel)
        Destroy(child.gameObject);

        slots.Clear();

        //create 60 slots
        for (int i = 0; i < totalSlots; i++)
        {
            GameObject newSlot = Instantiate(slotPrefab, gridPanel);
            slots.Add(newSlot);
        }

    }

    //fills slots with items
    public void RefreshInventory()
    {
        //loop through all slots
        for (int i = 0; i <totalSlots; i++)
        {
            Image iconUI = slots[i].GetComponent<Image>();

            if (i < Inventory_Manager.Instance.items.Count)
            {
                //show item icon
                iconUI.sprite = Inventory_Manager.Instance.items[i].icon;
                iconUI.color = Color.white;
            }
            else
            {
                //empty slot
                iconUI.sprite = null;
                iconUI.color = new Color(1, 1, 1, 0.1f); //faint empy slot
            }
        }
    }
}