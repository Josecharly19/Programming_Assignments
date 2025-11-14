using UnityEngine;
using UnityEngine.UI;

public class SlotUI : MonoBehaviour
{
    public GameObject slotPrefab;
    public Transform gridPanel;

    private void OnEnable()
    {
        RefreshInventory();
    }

    public void RefreshInventory()
    {
        //clear old slots
        foreach (Transform child in gridPanel)
        {
            Destroy(child.gameObject);
        }

        //adds a slot of each item
        foreach (Item item in Inventory_Manager.Instance.items)
        {
            GameObject slot = Instantiate(slotPrefab, gridPanel);

            //time assings icon
            slot.GetComponent<Image>().sprite = item.icon;
        }
    }
}
