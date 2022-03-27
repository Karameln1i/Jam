using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMusic : MonoBehaviour
{
   [SerializeField] private AudioSource _audioSource;

   private void Awake()
   {
      DontDestroyOnLoad(gameObject);
   }

   private void Update()
   {
      //Debug.Log(_audioSource.clip.);
   }
}
