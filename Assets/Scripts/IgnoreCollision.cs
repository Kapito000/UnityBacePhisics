using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollision : MonoBehaviour
{
    [SerializeField] Collider _one;
    [SerializeField] Collider _two;

    private void Awake()
    {
        if (!_one) _one = GetComponent<Collider>();
    }

    private void Start()
    {
        Physics.IgnoreCollision(_one, _two, true);
    }    
}
