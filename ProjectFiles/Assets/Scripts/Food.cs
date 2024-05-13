using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : Item
{
    [SerializeField]
    private float health;

    public Food()
    {
        itemName = "";
        value = 0;
        weight = 0;
        health = 0;
    }
    public Food(string name, int val, int weigh, int h, int num)
    {
        itemName = name;
        value = val;
        weight = weigh;
        health = h;
        count = num;
    }
    public Food(int id, string name, int val, int weigh, int h, int num)
    {
        itemID = id;
        itemName = name;
        value = val;
        weight = weigh;
        health = h;
        count = num;
    }


    public float getHealth()
    {
        return health;
    }
    public void setHealth(int newHealth)
    {
        health = newHealth;
    }
}
