using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeBackground : MonoBehaviour
{
    
    //cc = FPSController.GetComponents<CharacterController>();
    public GameObject detailedPanel;
    public bool isFrozen;
    public CharacterController controller;
    //private MouseLook[] mous;
    //public UnityStandardAssets.Characters.FirstPerson scr;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        controller = GetComponent<CharacterController>();
        isFrozen = false;
        if (detailedPanel.activeSelf == true){
            isFrozen = true;
        }
        else{
            isFrozen = false;
        }
        //mous = GetComponentsInChildren<MouseLook> ();

        if(isFrozen)
        {
            controller.enabled = false; 
            (GetComponent("FirstPersonController")as MonoBehaviour).enabled = false;
            //GetComponent(FirstPersonController).enabled = false;
            //GetComponents(FirstPersonController).enabled = false;
            //thisLooker.enabled = !thisLooker.enabled;
        }
        else{
            controller.enabled = true; 
            (GetComponent("FirstPersonController")as MonoBehaviour).enabled = true;
            //GetComponent(FirstPersonController).enabled = true;
            //GetComponents(FirstPersonController).enabled = true;
            isFrozen = false;
            //FPSController.SetActive(true); 
            //thisLooker.enabled = !thisLooker.enabled;
        }
    }
}
