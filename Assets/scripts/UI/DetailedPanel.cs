using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetailedPanel : MonoBehaviour
{
    public Button Scent1Button;
    public Button Scent2Button;
    public Button Scent3Button;
    public Button Scent4Button;

    public Animator DetailedPanelAnimator;

    public Button closeButton;

    public GameObject MiniDetectMenu;

    void Start()
    {
        Scent1Button.onClick.AddListener(call:() => 
        {
            DetailedPanelAnimator.SetTrigger(name:"Fadein");
            MiniDetectMenu.SetActive(false);
        });
        Scent2Button.onClick.AddListener(call:() => 
        {
            DetailedPanelAnimator.SetTrigger(name:"Fadein");
            MiniDetectMenu.SetActive(false);
        });
        Scent3Button.onClick.AddListener(call:() => 
        {
            DetailedPanelAnimator.SetTrigger(name:"Fadein");
            MiniDetectMenu.SetActive(false);
        });
        Scent4Button.onClick.AddListener(call:() => 
        {
            DetailedPanelAnimator.SetTrigger(name:"Fadein");
            MiniDetectMenu.SetActive(false);
        });
        closeButton.onClick.AddListener(call:() => 
        {
            DetailedPanelAnimator.SetTrigger(name:"Fadeout");
            MiniDetectMenu.SetActive(true);
        });
    }
}
