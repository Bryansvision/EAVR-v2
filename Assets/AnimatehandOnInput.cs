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

    public MenuManager menuManager;



    void Update()
    {
        float trigger = triggerValue.action.ReadValue<float>();
        float grip = gripValue.action.ReadValue<float>();

        bool pressed = pullUpMenu.action.ReadValue<bool>();

        handAnimator.SetFloat("Trigger",trigger);
        handAnimator.SetFloat("Grip",grip);

        if (pressed)
        {
            activeMenu();
        }
    }

    public void activeMenu()
    {
        menuManager.OpenCloseMenu(!transform.GetChild(0).gameObject.activeSelf);
    }
}
