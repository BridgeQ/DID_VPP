using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject[] inventory = new GameObject[10];
    public Button[] InventoryButtons = new Button[10];
    
    public void AddItem(GameObject item)
    {
        bool itemAdded = false;
        for (int i = 0; i < inventory.Length;i++){
            if(inventory[i] == null){
                inventory[i] = item;
                //Debug.Log(item.name +" was added");
                itemAdded = true;
                break;
            }
        }
        //if (!itemAdded){
        //    Debug.Log("Inventory Full - Item Not Added");
        //}
    }

    public void Remove(GameObject item)
    {
        bool itemRemoved = false;
        for (int i = 0; i < inventory.Length;i++){
            if(inventory[i] == item){
                inventory[i] = null;
                //Debug.Log(item.name +" was removed");
                itemRemoved = true;
                break;
            }
        }
        if (!itemRemoved){
            Debug.Log("remove failed");
        }
    }
}
