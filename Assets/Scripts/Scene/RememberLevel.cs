using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[Serializable]
public class RememberLevel:MonoBehaviour
{
    [SerializeField] private int _levelIndex;
    [SerializeField] private LevelComplitedPanel _levelComplitedPanel;
    
   /* private void Awake()
    {
        NextLevel nextLevel=NextLevel.Load();
        nextLevel.ChangeLevel(_levelIndex+=1);
        nextLevel.Save();  
    }*/
    
    
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
        NextLevel nextLevel=NextLevel.Load();
        nextLevel.ChangeLevel(_levelIndex+=1);
        nextLevel.Save();  
    }
}