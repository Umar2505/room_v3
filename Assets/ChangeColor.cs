using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update
    public Light light;
    void Start()
    {
        light = GetComponent<Light>();
        Color color = Color.white;
        if (color == Color.white & Input.GetKeyDown("tab"))
        {
            light.color = Color.blue;
            color = Color.blue;
        }
        else if (color == Color.blue & Input.GetKeyDown("tab")) 
        { 
            light.color = Color.white;
            color = Color.white;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
