using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.UI;

public class PlayerInteract : MonoBehaviour
{
    public GameObject currentInterObj = null;
    public GameObject currentScent = null;
    public InteractionObject currentInterObjScript = null;
    public Inventory inventory;
    public ScentsDisplay scents;
    
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.I)){
            //check if to be stored inventory
            //if(currentInterObjScript.inventory){
            //    inventory.AddItem(currentInterObj);
            //}
            //Debug.Log("Hello????");
            //check if the object can talk
            if (currentInterObjScript.talks){
                //Debug.Log("hereeeeeee");
                currentInterObjScript.Talk();
            }
            //do something with the object
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("InterObject")){
            //Debug.Log(other.name);
            currentInterObj = other.gameObject;
            currentInterObjScript = currentInterObj.GetComponent<InteractionObject>();
            if (currentInterObjScript.talks){
                currentInterObjScript.showHints();
            }
        }
    }

      void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Scents")){
            //Debug.Log(other.name);
            currentScent = other.gameObject;
            scents.AddItem(currentScent);
        }
    }

       void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("InterObject")){
            if (other.gameObject == currentInterObj){
                currentInterObj = null;
                
            }
        }
         if(other.CompareTag("Scents")){
            scents.Remove(other.gameObject);
        }
        if (currentInterObjScript.talks){
            currentInterObjScript.hideHints();
        }
    }

    
 
 
}
