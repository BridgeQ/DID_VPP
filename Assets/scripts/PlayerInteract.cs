using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class PlayerInteract : MonoBehaviour
{
    public GameObject currentInterObj = null;
    public GameObject currentScent = null;
    public InteractionObject currentInterObjScript = null;
    public Inventory inventory;
    public ScentsDisplay scents;
   
    
    void Updates()
    {
        
        if(Input.GetButtonDown("Interact")&& currentInterObj){
            //check if to be stored inventory
            if(currentInterObjScript.inventory){
                inventory.AddItem(currentInterObj);
            }
            //do something with the object
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("InterObject")){
            //Debug.Log(other.name);
            currentInterObj = other.gameObject;
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
                currentInterObjScript = currentInterObj.GetComponent<InteractionObject>();
            }
        }
         if(other.CompareTag("Scents")){
            scents.Remove(other.gameObject);
        }
    }
 
 
}
