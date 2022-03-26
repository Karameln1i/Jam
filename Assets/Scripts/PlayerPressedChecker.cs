using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPressedChecker : MonoBehaviour
{
    private bool _pressed;

    public bool Pressed => _pressed;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _pressed = true;
        }
        
        if (Input.GetMouseButtonUp(0))
        {
            _pressed = false;
        }
    }
}
