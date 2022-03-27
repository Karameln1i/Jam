using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Figure : MonoBehaviour
{
    [SerializeField] private List<PartEdge> _partEdges=new List<PartEdge>();
    [SerializeField] private PlayerPressedChecker _playerPressedChecker;
    [SerializeField] private PlayBoobEffects _playBoobEffects;
    [SerializeField] private GameObject _fullFigure;
    [SerializeField] private GameObject _allFigures;
    [SerializeField] private GameObject _handle;
    [SerializeField] private bool _isFirstLevel;
    
    private int _connectedEdges;

    public event UnityAction Collected;
    
    private void OnEnable()
    {
        _playBoobEffects.Exploded += OnExploaded;
        
        for (int i = 0; i < _partEdges.Count; i++)
        {
            _partEdges[i].Connected += OnConnected;
        }
       
    }

    private void OnDisable()
    {
        _playBoobEffects.Exploded -= OnExploaded;
        
        for (int i = 0; i < _partEdges.Count; i++)
        {
            _partEdges[i].Connected -= OnConnected;
        }
    }

    private void Update()
    {
        
        
        for (int i = 0; i < _partEdges.Count; i++)
        {
            if (_partEdges[i].IsConnected)
            {
                _connectedEdges++;
            }
        }

        if (_connectedEdges==_partEdges.Count&&!_playerPressedChecker.Pressed)
        {
            //Debug.Log("готово");
            Collected?.Invoke();
            if (_isFirstLevel)
            {
                _handle.SetActive(false);
            }
        }
        else
        {
            _connectedEdges = 0;
        }
        
        
        
    }

    private void OnExploaded()
    {
        Debug.Log("вызвалось");
        _allFigures.SetActive(false);
        _fullFigure.SetActive(true);
    }
    
    private void OnConnected()
    {
        _connectedEdges++;
        
        if (_connectedEdges==_partEdges.Count&&!_playerPressedChecker.Pressed)
        {
            Debug.Log("готово");
            Collected?.Invoke();
                
        }
      
    }
}
