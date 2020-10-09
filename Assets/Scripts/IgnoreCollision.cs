using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollision : MonoBehaviour
{
    [SerializeField] Collider _one = null;
    [SerializeField] Collider _two = null;
    
    private void Awake()
    {
        if (!_one) _one = GetComponent<Collider>();
    }

    private void Start()
    {
        Physics.IgnoreCollision(_one, _two, true);
    }    
}
