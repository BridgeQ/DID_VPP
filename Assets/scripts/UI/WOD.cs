using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WOD : MonoBehaviour
{
    public GameObject WODon;
    public GameObject WODoff;
    public GameObject WODemitting;
    public GameObject MiniDetectMenu;
    public GameObject Detecting;
    public GameObject Emitting;
    public GameObject DetailedPanel;
    public GameObject DialoguePanel;
  
    void Update()
    {
        //Detect the scent
        if (Input.GetKeyDown(KeyCode.E))
        {
            WODoff.SetActive(false);
            WODemitting.SetActive(false);
            WODon.SetActive(true);
            MiniDetectMenu.SetActive(true);
            Detecting.SetActive(true);
            Emitting.SetActive(false);
            DetailedPanel.SetActive(false);
        }
        //Emit the scent
        if (Input.GetKeyDown(KeyCode.F))
        {
            WODoff.SetActive(false);
            WODemitting.SetActive(true);
            WODon.SetActive(false);
            MiniDetectMenu.SetActive(false);
            Detecting.SetActive(false);
            Emitting.SetActive(true);
            DetailedPanel.SetActive(false);
        }
        //Turn off the WOD
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            WODoff.SetActive(true);
            WODemitting.SetActive(false);
            WODon.SetActive(false);
            MiniDetectMenu.SetActive(false);
            Detecting.SetActive(false);
            Emitting.SetActive(false);
            DetailedPanel.SetActive(false);
            DialoguePanel.SetActive(false);
        }
    }

    public void ClosePanel(){
        DialoguePanel.SetActive(false);
    }

    
        
    

}
