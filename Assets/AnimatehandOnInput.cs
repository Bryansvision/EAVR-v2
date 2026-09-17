using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimatehandOnInput : MonoBehaviour
{
    public InputActionProperty triggerValue;
    public InputActionProperty gripValue;
    public InputActionProperty pullUpMenu;

    public Animator handAnimator;
    public GameObject bigCanvas;

    public MenuManager menuManager;

    private bool pressedDown = false;
    private bool menuIsOpen = false;



    void Update()
    {
        float trigger = triggerValue.action.ReadValue<float>();
        float grip = gripValue.action.ReadValue<float>();

        bool pressed = pullUpMenu.action.IsPressed();
       

        handAnimator.SetFloat("Trigger",trigger);
        handAnimator.SetFloat("Grip",grip);


        if (pressed && pressedDown == false)
        {
            activeMenu();
            Debug.Log("Buttons working proper");
            pressedDown = true;
        }
        else if (!pressed) {
         pressedDown = false;
        }
    }

    public void activeMenu()
    {
        if (menuIsOpen == false)
        {
            menuManager.OpenCloseMenu(true);
        }
        else
        {
            menuManager.OpenCloseMenu(false);
        }
        
      
    }
}
