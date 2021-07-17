using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WOD : MonoBehaviour
{
    public int TapE;
    public GameObject WODon;
    public GameObject WODoff;
    public GameObject WODemitting;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TapE++;
        }
        if (TapE == 1)
        {
            WODoff.SetActive(false);
            WODemitting.SetActive(false);
            WODon.SetActive(true);
        }
        else
        {
            WODon.SetActive(false);
            TapE = 0;
        }
    }
}
