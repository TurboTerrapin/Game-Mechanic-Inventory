using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : Item
{
    [SerializeField]
    private int armorPoints;
    public enum ARMORTYPE
    {
        Helmet,
        Chestplate,
        Gauntlets,
        Greaves

    }
    [SerializeField]
    private ARMORTYPE armorType;


    public Armor()
    {
        itemName = "";
        value = 0;
        weight = 0;
        armorPoints = 0;
        armorType = ARMORTYPE.Helmet;
    }
    public Armor(string name, int val, int weigh, int ap, ARMORTYPE type, int num)
    {
        itemName = name;
        value = val;
        weight = weigh;
        armorPoints = ap;
        armorType = type;
        count = num;
    }
    public Armor(int id, string name, int val, int weigh, int ap, ARMORTYPE type, int num)
    {
        itemID = id;
        itemName = name;
        value = val;
        weight = weigh;
        armorPoints = ap;
        armorType = type;
        count = num;
    }



    public int getArmor()
    {
        return armorPoints;
    }
    public ARMORTYPE getArmorType()
    {
        return armorType;
    }

    public void setArmor(int newArmor)
    {
        armorPoints = newArmor;
    }
    public void setArmorType(ARMORTYPE newArmorType)
    {
        armorType = newArmorType;
    }


}
