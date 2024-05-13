using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayValues : MonoBehaviour
{
    [SerializeField]
    private Player player;

    [SerializeField]
    private TextMeshProUGUI itemName;
    [SerializeField]
    private TextMeshProUGUI itemValue;
    [SerializeField]
    private TextMeshProUGUI itemWeight;
    [SerializeField]
    private TextMeshProUGUI itemDamage;
    [SerializeField]
    private TextMeshProUGUI itemArmor;
    //[SerializeField]
    //private TextMeshProUGUI armorType;
    [SerializeField]
    private TextMeshProUGUI itemCount;


    public int i;


    private Item currentItem;


    // Update is called once per frame
    void Update()
    {
        List<Item> itemList = player.getInventory().getItemList();

        if (itemList.Count > 0 && i < itemList.Count)
        {
            currentItem = itemList[i];
            itemName.text = itemList[i].getName();
            itemValue.text = "" + itemList[i].getValue();
            itemWeight.text = "" + itemList[i].getWeight();
            itemCount.text = "" + itemList[i].getCount();
            //itemName.text = itemList[i];
        }
    }


    public void makeActiveItem()
    {
        Debug.Log("Active Item is now " + currentItem.getName());

        player.gameObject.GetComponent<PlayerMove>().changeCurrentItem(currentItem);
    }

}
