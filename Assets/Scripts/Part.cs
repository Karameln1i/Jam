using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(DragAndDrop))]
public class Part : MonoBehaviour
{
    [SerializeField] private List<PartEdge>  _partEdges=new List<PartEdge>();

    private int _connectedEdges;
    
    private DragAndDrop _dragAndDrop;

    private void Awake()
    {
        _dragAndDrop = GetComponent<DragAndDrop>();
        _connectedEdges = _partEdges.Count;
    }

    private void OnEnable()
    {
        for (int i = 0; i < _partEdges.Count; i++)
        {
            _partEdges[i].Connected += OnConnected;
        }
       
    }

    private void OnDisable()
    {
        for (int i = 0; i < _partEdges.Count; i++)
        {
            _partEdges[i].Connected -= OnConnected;
        }
    }

    private void OnConnected()
    {
        _connectedEdges++;
        
        if (_connectedEdges==_partEdges.Count)
        {
            _dragAndDrop.enabled = false;
        }
      
    }
}
