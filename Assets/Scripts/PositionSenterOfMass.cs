using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionSenterOfMass : MonoBehaviour
{
    [SerializeField] Rigidbody _rigidbody;

    private void FixedUpdate()
    {
        if (!Check()) return;

        _rigidbody.centerOfMass = transform.localPosition;
    }

    bool Check()
    {
        if (_rigidbody) return true;
        return false;
    }
    private void Awake()
    {
        if (GetComponent<Rigidbody>())
            _rigidbody = GetComponent<Rigidbody>();
    }
}
