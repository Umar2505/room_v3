using System.Collections;
using System.Collections.Generic;
using Unity.XR.Oculus.Input;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;
using UnityEngine.UI;

public class Quit : MonoBehaviour
{
    public InputActionReference action;
    void Start()
    {
        
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.quit();
            #endif
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
