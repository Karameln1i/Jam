using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelIndex : MonoBehaviour
{
    [SerializeField] private LevelComplitedPanel _levelComplitedPanel;
    
    private const string Level_Index = "Level_Index";
    
    private int _levelIndex
    {
        get { return PlayerPrefs.GetInt(Level_Index, 1); }
        set { PlayerPrefs.SetInt(Level_Index, value); }
    }

    private void OnEnable()
    {
        _levelComplitedPanel.Opened += OnLevelComplitedPanelOpened;
    }

    private void OnDisable()
    {
        _levelComplitedPanel.Opened -= OnLevelComplitedPanelOpened;
    }

    private void OnLevelComplitedPanelOpened()
    {
        _levelIndex += 1;
    }
    
    public int GetValue()
    {
        return _levelIndex;
    }
}
