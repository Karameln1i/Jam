
using UnityEngine;
using UnityEngine.Events;

public class PartEdge : MonoBehaviour
{
   [SerializeField] private int _index;
   [SerializeField] private ParticleSystem _effect;
   
   private bool _playConnectedEffect;

   private void Awake()
   {
       if (_effect!=null)
       {
           _playConnectedEffect = true;
       }
   }

   private bool _isConnected;

   public bool IsConnected => _isConnected;

   public int Index => _index;
   
   public event UnityAction Connected;

   public void Connect()
   {
       _isConnected = true;
       if (_playConnectedEffect)
       {
          _effect.Play();
       }
   }

   public void Disconect()
   {
       _isConnected = false;
   }
}
