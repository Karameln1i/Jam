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
}
