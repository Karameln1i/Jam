using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseSoundSetting : MonoBehaviour
{
    [SerializeField] private GameObject _soundSetting;

    public void CloseSetting ()
    {
        _soundSetting.SetActive(false);
    }
}
