using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private Player player;
    
    [SerializeField]
    private GameObject inventoryScreen;
    
    public Vector2 move;

    public float speed;

    private bool inMenu;

    public Item currentItem;

    // Start is called before the first frame update
    void Start()
    {
        inventoryScreen.SetActive(false);

        currentItem = new Item(1, "Coin", 1, 0, 1);
        //tempItem.setName("Coin");
    }

    // Update is called once per frame
    void Update()
    {
        move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        move *= Time.deltaTime * speed;

        gameObject.transform.Translate(move.x, 0, move.y);

        if(Input.GetKeyDown(KeyCode.Tab))
        {
            changeScreen();
        }

        if(Input.GetKeyDown(KeyCode.Q))
        {
            Item item = player.getInventory().removeItem(currentItem);

            if (item != null)
            {                
                SpawnManager manager = player.getManager();

                manager.spawnObject(item.getID());
            }
        }

    }

    private void changeScreen()
    {
        switch (inMenu)
        {
            case false:
                inMenu = true;
                inventoryScreen.SetActive(true);
                Cursor.lockState = CursorLockMode.Confined;
                break;
            case true:
                inMenu = false;
                inventoryScreen.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                break;
        }
    }

    public void changeCurrentItem(Item item)
    {
        currentItem = item;
    }

}