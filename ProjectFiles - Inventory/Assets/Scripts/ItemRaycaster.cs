using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemRaycaster : MonoBehaviour
{

    [SerializeField]
    private GameObject player;

    [SerializeField]
    private TextMeshProUGUI itemNameText;

    private Inventory inventory;

    // Start is called before the first frame update
    void Start()
    {
        inventory = player.GetComponent<Player>().getInventory();
    }

    // Update is called once per frame
    void Update()
    {
        Color color = Color.red;

        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, 10))
        {

            if(hit.collider.GetComponent<ItemComponent>())
            {
                color = Color.green;

                itemNameText.text = hit.collider.gameObject.GetComponent<ItemComponent>().getItem().getName();

                if (Input.GetKeyDown(KeyCode.E))
                {
                    GameObject hitObject = hit.collider.gameObject;

                    Item item = hitObject.GetComponent<ItemComponent>().getItem();

                    inventory.addItem(item);

                    Destroy(hit.collider.gameObject);
                }
            }
            else if(hit.collider.gameObject.transform.parent && hit.collider.gameObject.transform.parent.GetComponent<ItemComponent>())
            {
                color = Color.blue;

                string name = hit.collider.gameObject.transform.parent.GetComponent<ItemComponent>().getItem().getName();
                itemNameText.text = name;

                if (Input.GetKeyDown(KeyCode.E))
                {
                    GameObject hitObject = hit.collider.gameObject;

                    Item item = hitObject.transform.parent.GetComponent<ItemComponent>().getItem();

                    inventory.addItem(item);

                    Destroy(hitObject.transform.parent.gameObject);
                }
            }
            else
            {
                itemNameText.text = "";
            }
        }
        else
        {
            itemNameText.text = "";
        }
        Debug.DrawRay(transform.position, transform.forward * hit.distance, color);
    }
}
