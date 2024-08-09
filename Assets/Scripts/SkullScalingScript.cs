using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SkullScalingScript : MonoBehaviour
{
    SkullScaling action;

    void Awake()
    {
        action = new SkullScaling();    
    }

    void OnEnable()
    {
        action.Enable();
        action.Scaling.ScaleUp.performed += OnRightButtonClicked;
        action.Scaling.ScaleDown.performed += OnLeftButtonClicked;
    }

    private void OnRightButtonClicked(InputAction.CallbackContext context)
    {
        gameObject.transform.localScale += new Vector3(0.05f, 0.05f, 0.05f);   
    }

    void OnDisable()
    {
        action.Disable();
        action.Scaling.ScaleUp.performed -= OnRightButtonClicked;
        action.Scaling.ScaleDown.performed -= OnLeftButtonClicked;
    }

    private void OnLeftButtonClicked(InputAction.CallbackContext context)
    {
        gameObject.transform.localScale -= new Vector3(0.05f, 0.05f, 0.05f);
    }

}
