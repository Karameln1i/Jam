using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveBehavior : MonoBehaviour
{
    [SerializeField] private SwipeInput _swipeInput;

    private void OnEnable()
    {
        _swipeInput.Swiped += OnSwiped;
    }

    private void OnSwiped(SwipeDirection direction)
    {
        if (direction==SwipeDirection.Left)
        {
            Debug.Log("swipedLeft");
        }
        else if (direction==SwipeDirection.Right)
        {
            Debug.Log("swipedRight");
        }
        else if (direction==SwipeDirection.Up)
        {
            Debug.Log("swipedUp");
        }
        else if (direction==SwipeDirection.Down)
        {
            Debug.Log("Down");
        }
    }
}
