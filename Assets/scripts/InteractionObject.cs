using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionObject : MonoBehaviour
{
    public bool inventory; //if true this object can be stored in inventory
    public bool talks;
    public GameObject player;
    public string message;
    //public string message2;
    public string name;
    public string answer;
    //public string answer2;
    public GameObject NameDisplay;
    public GameObject MessageDisplay;
    public GameObject AnswerDisplay;
    public GameObject DialoguePanel;
    public GameObject hint;
    public bool OnlyOne = false;
    public void DoInteraction()
    {
        //add in inventory
        //pick up
        //gameObject.SetActive(false);
    }
    public void Talk(){
        Debug.Log(message);
        DialoguePanel.SetActive(true);
        NameDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = name;
        MessageDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = message;
        AnswerDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = answer;
    }
    public void showHints(){
        //GameObject hint = GameObject.FindGameObjectWithTag("Hint");
        //transform.LookAt(player.transform);
        hint.SetActive(true);
    }
    public void hideHints(){
        //GameObject hint = GameObject.FindGameObjectWithTag("Hint");
        //transform.LookAt(player.transform);
        hint.SetActive(false);
    }
}

    
