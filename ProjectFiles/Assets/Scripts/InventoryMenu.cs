using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InventoryMenu : MonoBehaviour
{


    [SerializeField]
    private GameObject inventoryPrefab;
    private Inventory inventory;
    [SerializeField]
    private Transform parent;



    public void setInventory(Inventory inv)
    {
        inventory.OnItemListChanged += Inventory_OnItemListChanged;
    }

    private void Inventory_OnItemListChanged(object sender, System.EventArgs e)
    {
        updateInventory();
    }

    public void updateInventory()
    {
        foreach(Transform child in parent)
        {
            if(child == inventoryPrefab)
            {
                continue;
            }
            Destroy(child.gameObject);
        }

        int i = 0;
        foreach (Item item in inventory.getItemList())
        {
            GameObject invUi = Instantiate(inventoryPrefab, transform);
            invUi.GetComponent<DisplayValues>().i = i;
            i++;
        }
    }


}
