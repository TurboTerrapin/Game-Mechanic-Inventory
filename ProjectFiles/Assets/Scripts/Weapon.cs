using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item
{
    [SerializeField]
    private int damage;


    public Weapon()
    {
        itemName = "";
        value = 0;
        weight = 0;
        damage = 0;
    }
    public Weapon(string name, int val, int weigh, int d, int num)
    {
        itemName = name;
        value = val;
        weight = weigh;
        damage = d;
        count = num;
    }
    public Weapon(int id, string name, int val, int weigh, int d, int num)
    {
        itemID = id;
        itemName = name;
        value = val;
        weight = weigh;
        damage = d;
        count = num;
    }


    public int getDamage()
    {
        return damage;
    }

    public void setDamage(int newDamage)
    {
        damage = newDamage;
    }

}
