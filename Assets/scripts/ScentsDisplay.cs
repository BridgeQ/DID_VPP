using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScentsDisplay : MonoBehaviour
{
    public GameObject[] scents = new GameObject[5];
    public Button[] ScentsButtons = new Button[5];
    public Sprite defaultSprite = null;
    
    public void AddItem(GameObject item)
    {
        bool itemAdded = false;
        bool duplicated = false;
        //check if item is already in the list
        for (int j = 0; j < scents.Length;j++){
            if (scents[j]==item){
                duplicated = true;
                break;
            }
        }
        // if item is unique
        if (!duplicated){
        for (int i = 0; i < scents.Length;i++){
            if(scents[i] == item){
                break;
            }
            else if (scents[i] == null){
                scents[i] = item;
                //update UI
                ScentsButtons[i].image.overrideSprite = item.GetComponent<Image>().sprite;
                ScentsButtons[i].GetComponentInChildren<Text>().text = item.name;
                Debug.Log(item.name +" was added");
                itemAdded = true;
                break;
            }
        }
        }
        if (!itemAdded){
            Debug.Log("scents Full - Item Not Added");
        }
    }

    public void Remove(GameObject item)
    {
        bool itemRemoved = false;
        for (int i = 0; i < scents.Length;i++){
            if(scents[i] == item){
                scents[i] = null;
                //update UI
                ScentsButtons[i].image.overrideSprite = defaultSprite;
                ScentsButtons[i].GetComponentInChildren<Text>().text = "Empty";
                Debug.Log(item.name +" was removed");
                itemRemoved = true;
                break;
            }
        }
        if (!itemRemoved){
            Debug.Log("remove failed");
        }
    }
}
