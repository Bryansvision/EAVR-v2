using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputVr : MonoBehaviour
{
    public InputActionProperty inputValue;
    public InputActionProperty buttonValue;

    void Start()
    {
        
    }

   
    void Update()
    {
        float value = inputValue.action.ReadValue<float>();

        bool buttonvalue = buttonValue.action.IsPressed();
    }
}
