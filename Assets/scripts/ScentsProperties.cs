using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
 

public class ScentsProperties : MonoBehaviour
{
    public string name;
    public string address;
    public string resources;
    public GameObject nameDisplay;
    public GameObject addressDisplay;
    public GameObject resourcesDisplay;
    public GameObject[] buttons = new GameObject[4];
    //public Button currentButton;
    //public static GameObject selectedButton;
    //string selectedButton = EventSystem.current.currentSelectedGameObject.name;
    //ButtonName = selectedButton.GetComponentInChildren<TMPro.TextMeshProUGUI>().text;
    
    //public void OnClicked(Button button)
    //{
    //    print(button.name);
    //}
    public GameObject selectedButton(){
        GameObject selectedButton = EventSystem.current.currentSelectedGameObject;
        return selectedButton;
    }

    public void setOutline(GameObject crtButton){
        for (int i = 0; i < buttons.Length;i++){
            buttons[i].GetComponent<Outline>().enabled = false;
        }
        crtButton.GetComponent<Outline>().enabled = true;
    }
    
    public void setText(){
        //Debug.Log("hi checkkkk");
        GameObject currentButton = null;
        currentButton = selectedButton();
        string ScentName = currentButton.GetComponentInChildren<TMPro.TextMeshProUGUI>().text;
        setOutline(currentButton);

        //Debug.Log(ScentName);
        getProperties(ScentName);
        if (ScentName != "None"){
            nameDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = name;
            addressDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = address;
            resourcesDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = resources;
        }
    }

    public void getProperties(string ScentName){
    switch(ScentName) {
        case "Pizza":
            name = "Pizza";
            address = "145 Harvard Ave";
            resources = "Papa Johns\nPizza Hut";
            break; 
        case "Fish":
            name = "Fish";
            address = "138 Harvard Ave";
            resources = "Fish Market\nHarbour\nFishermen";
            break; 
        case "Trash":
            name = "Trash";
            address = "138 Harvard Ave";
            resources = "Trash Bins\nCycling Plants\nRestaurant Food Waste\nBack Alleies";
            break; 
        case "Car Cleaner":
            name = "Car Cleaner";
            address = "138 Harvard Ave";
            resources = "Car Washing Store\nMotor Maintainance";
            break; 
        case "Fragrance":
            name = "Frangrance";
            address = "138 Harvard Ave";
            resources = "Frangrance Store";
            break; 
        case "Linseed Oil":
            name = "Linseed Oil";
            address = "140 Harvard Ave";
            resources = "Violin\nWood Working";
            break; 
        case "Rose Scented Candle":
            name = "Rose Scented Candle";
            address = "140 Harvard Ave";
            resources = "Candle Store\nEnvironmental Frangrance";
            break; 
        case "Moldy Wood":
            name = "Moldy Wood";
            address = "140 Harvard Ave";
            resources = "Old Wood Structured Building\nOld Wooden Musical Instriments\nWood Strusture Near Water";
            break; 
        case "Blood":
            name = "Human Blood";
            address = "138 Harvard Ave";
            resources = "";
            break;
        
        case "None":
            name = "SCENTS NAME";
            address = "LOCATION NAME";
            resources = "RESOURCE NAME";
            break; 

    }
    }
        
}
