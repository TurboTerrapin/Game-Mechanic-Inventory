using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Inventory
{
    public event EventHandler OnItemListChanged;

    [SerializeField]
    private List<Item> itemList;
    [SerializeField]
    private List<Weapon> weaponList;
    [SerializeField]
    private List<Armor> armorList;

    [SerializeField]
    private int totalWeight;

    public Inventory()
    {
        itemList = new List<Item>();
    }

    public List<Item> getItemList()
    {
        return itemList;
    }

    public void addItem(Item item)
    {
        Item itemToBeUpdated = new Item();
        bool containsItem = false;
        foreach(Item invItem in itemList)
        {
            if(item.getName() == invItem.getName())
            {
                itemToBeUpdated = invItem;
                containsItem = true;
            }
        }

        if (containsItem)
        {
            itemToBeUpdated.setCount(1);
            OnItemListChanged?.Invoke(this, EventArgs.Empty);
            updateTotalWeight();
        }
        else
        {
            itemList.Add(item);
            OnItemListChanged?.Invoke(this, EventArgs.Empty);
            updateTotalWeight();
        }

        itemList.Sort(alphabeticalSort);
    }

    public Item removeItem(Item item)
    {
        if(item == null)
        {
            return null;
        }

        Item itemToBeUpdated = new Item();
        bool containsItem = false;

        foreach (Item invItem in itemList)
        {
            if (item.getName() == invItem.getName())
            {
                itemToBeUpdated = invItem;
                containsItem = true;
            }
        }

        if(containsItem)
        {
            if(itemToBeUpdated.getCount() > 1)
            {
                itemToBeUpdated.setCount(-1);
                OnItemListChanged?.Invoke(this, EventArgs.Empty);
                updateTotalWeight();
                return itemToBeUpdated;
            }
            else
            {
                itemList.Remove(itemToBeUpdated);
                OnItemListChanged?.Invoke(this, EventArgs.Empty);
                updateTotalWeight();
                return itemToBeUpdated;
            }
        }

        return null;
    }

    public void sortList(int i)
    {
        switch (i)
        {
            case 0:
                itemList.Sort(alphabeticalSort);
                break;
            case 1:
                itemList.Sort(valueSort);
                break;
            case 2:
                itemList.Sort(weightSort);
                break;
                /*
            case 3:
                weaponList.Sort(damageSort);
                break;
            case 4:
                armorList.Sort(armorSort);
                break;
            case 5:
                armorList.Sort(armorTypeSort);
                break;
                */
        }
    }

    public void updateTotalWeight()
    {
        totalWeight = 0;
        foreach (Item item in itemList)
        {
            totalWeight += item.getWeight() * item.getCount();
        }
    }
    public int getTotalWeight()
    {
        return totalWeight;
    }


    public int getInventorySize()
    {
        return itemList.Count;
    }

    static int alphabeticalSort(Item i1, Item i2)
    {
        return i1.getName().CompareTo(i2.getName());
    }
    static int valueSort(Item i1, Item i2)
    {
        return -i1.getValue().CompareTo(i2.getValue());
    }
    static int weightSort(Item i1, Item i2)
    {
        return -i1.getWeight().CompareTo(i2.getWeight());
    }
    static int damageSort(Weapon i1, Weapon i2)
    {
        return i1.getDamage().CompareTo(i2.getDamage());
    }
    static int armorSort(Armor i1, Armor i2)
    {
        return i1.getArmor().CompareTo(i2.getArmor());
    }
    static int armorTypeSort(Armor i1, Armor i2)
    {
        return i1.getArmorType().CompareTo(i2.getArmorType());
    }

}
