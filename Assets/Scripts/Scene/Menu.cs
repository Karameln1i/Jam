using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private Figure _figure;
    [SerializeField] private LevelComplitedPanel _levelComplitedPanel;

    private void OnEnable()
    {
        _figure.Collected += OnFigureCollected;
    }

    private void OnFigureCollected()
    {
        _figure.Collected -= OnFigureCollected;
        _levelComplitedPanel.Open();
    }
}
