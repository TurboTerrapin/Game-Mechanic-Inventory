using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemComponent : MonoBehaviour
{
    private Item item;


    
    public enum TYPE
    {
        Item,
        Weapon,
        Armor,
        Food
    }
    [SerializeField]
    private TYPE type;

    [SerializeField]
    private int itemId;
    [SerializeField]
    private string itemName;
    [SerializeField]
    private int value;
    [SerializeField]
    private int weight;
    [SerializeField]
    private int damage;
    [SerializeField]
    private int armor;
    [SerializeField]
    private Armor.ARMORTYPE armorType;
    [SerializeField]
    private int healing;


    void Start()
    {
        switch (type)
        {
            case TYPE.Item:
                item = new Item(itemId, itemName, value, weight, 1);
                break;
            case TYPE.Weapon:
                item = new Weapon(itemId, itemName, value, weight, damage, 1);
                break;
            case TYPE.Armor:
                item = new Armor(itemId, itemName, value, weight, armor, armorType, 1);
                break;
            case TYPE.Food:
                item = new Food(itemId, itemName, value, weight, healing, 1);
                break;
        }
    }


    public Item getItem()
    {
        return item;
    }
    public void setItem(Item newItem)
    {
        item = newItem;
    }

    public void destroy()
    {
        Destroy(gameObject);
    }


}
