using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorController : MonoBehaviour
{
   [SerializeField] private Animator myDoor = null;
   //[SerializeField] private bool openTrigger = false;
   //[SerializeField] private bool closeTrigger = false;
    private bool doorOpened = false;
    [SerializeField] private string doorOpen = "DoorOpen";
    [SerializeField] private string doorClose = "DoorClose";

   private void OnTriggerEnter(Collider other)
   {
       if (other.CompareTag("Player")&&doorOpened == false)
       {
           //if(openTrigger){
               myDoor.Play(doorOpen, 0, 0.0f);
               doorOpened = true;
           //}
          
       }
   }
    
   
   private void OnTriggerExit(Collider other)
   {
        if (other.CompareTag("Player")&& doorOpened == true)
       {
           
           //if (closeTrigger){
               myDoor.Play(doorClose, 0, 0.0f);
               doorOpened = false;
           //}

       }
   }
}
