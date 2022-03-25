using System;
using UnityEngine;

public class MouseInputRouter : MonoBehaviour, IPointerInputRouter
{
    public Vector2 Position { get; private set; }
    
    public event Action Pressed;
    
    public event Action Moved;
    
    public event Action Released;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Position = Input.mousePosition;
            Pressed?.Invoke();
        }

        if (Input.GetMouseButton(0))
        {
            if (Position != (Vector2) Input.mousePosition)
            {
                Position = Input.mousePosition;
                Moved?.Invoke();
            }
        }
        
        if (Input.GetMouseButtonUp(0))
        {
            if (Position != (Vector2) Input.mousePosition)
            {
                Position = Input.mousePosition;
                Released?.Invoke();
            }
        }
    }
}