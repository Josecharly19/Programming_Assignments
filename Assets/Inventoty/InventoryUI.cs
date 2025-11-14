using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryPanel;
    private bool isOpen = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            isOpen = !isOpen;
            inventoryPanel.SetActive(isOpen);

            //pause game while open
            Time.timeScale = isOpen ? 0f : 1f;
        }
    }
    
}
