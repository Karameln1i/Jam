using System.Collections;
using System.Collections.Generic;
using UnityEditor.Networking.PlayerConnection;
using UnityEngine;
using UnityEngine.Events;

public class PartEdge : MonoBehaviour
{
   [SerializeField] private int _index;

   public int Index => _index;
   
   public event UnityAction Connected;

   public void Connect()
   {
      Connected?.Invoke();
   }
}
