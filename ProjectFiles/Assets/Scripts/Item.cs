using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    [SerializeField]
    protected int itemID;
    [SerializeField]
    protected string itemName;
    [SerializeField]
    protected int value;
    [SerializeField]
    protected int weight;
    [SerializeField]
    protected int count;

    public Item()
    {
        itemID = -1;
        itemName = "";
        value = 0;
        weight = 0;
        count = 0;
    }
    public Item(string name, int v, int w, int num)
    {
        itemID = -1;
        itemName = name;
        value = v;
        weight = w;
        count = num;
    }
    public Item(int id, string name, int v, int w, int num)
    {
        itemID = id;
        itemName = name;
        value = v;
        weight = w;
        count = num;
    }

    public string getName()
    {
        return itemName;
    }
    public int getValue()
    {
        return value;
    }
    public int getWeight()
    {
        return weight;
    }
    public int getID()
    {
        return itemID;
    }
    public int getCount()
    {
        return count;
    }

    public void setName(string newName)
    {
        itemName = newName;
    }
    public void setValue(int newValue)
    {
        value = newValue;
    }
    public void setWeight(int newWeight)
    {
        weight = newWeight;
    }
    public void setCount(int change)
    {
        count += change;
    }
}
