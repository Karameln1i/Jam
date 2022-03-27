using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSoundSettings : MonoBehaviour
{
    [SerializeField] private GameObject _soundSetting;

    public void OpenSoundSetting()
    {
        _soundSetting.SetActive(true);
    }

}
