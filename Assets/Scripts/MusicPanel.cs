using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPanel : MonoBehaviour
{
    [SerializeField] private GameObject _cube;

    private void OnEnable()
    {
        _cube.gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        _cube.gameObject.SetActive(true);
    }
}
