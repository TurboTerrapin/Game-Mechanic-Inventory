using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Inventory inventory;

    [SerializeField]
    private SpawnManager spawnManager;

    void Awake()
    {
        inventory = new Inventory();
    }

    public Inventory getInventory()
    {
        return inventory;
    }

    public SpawnManager getManager()
    {
        return spawnManager;
    }

    public void sortInventory(int i)
    {
        inventory.sortList(i);
    }


}
