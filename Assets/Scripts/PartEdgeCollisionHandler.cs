using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PartEdge))]
public class PartEdgeCollisionHandler : MonoBehaviour
{
    private PartEdge _partEdge;

    private void Awake()
    {
        _partEdge = GetComponent<PartEdge>();
    }
    
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.TryGetComponent<PartEdge>(out PartEdge partEdge))
        {
          _partEdge.Connect();
          partEdge.Connect();
        }
    }
    
    private void OnTriggerExit(Collider collider)
    {
        if (collider.TryGetComponent<PartEdge>(out PartEdge partEdge))
        {
            _partEdge.Disconect();
            partEdge.Disconect();
        }
    }
}
