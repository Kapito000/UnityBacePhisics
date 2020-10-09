using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibleCenterOfMass : MonoBehaviour
{
    [SerializeField] GameObject _target = null;
    [SerializeField] Transform _fromRay = null;
    [SerializeField] float _radius = 0.2f;

    Rigidbody _rigidbody;


    private void FixedUpdate()
    {
        var centerOfMass = _rigidbody.worldCenterOfMass;
        var strtRay = new Vector3(centerOfMass.x, centerOfMass.y, _fromRay.position.z);
        if (Physics.Raycast(strtRay, Vector3.forward, out var hit))
        {
            _target.transform.position = hit.point;
        }
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
    private void OnDrawGizmos()
    {
        if (!Check()) return;

        var centrPoint = _rigidbody.worldCenterOfMass;

        Gizmos.color = Color.red;
        Gizmos.DrawSphere(centrPoint, _radius);
    }
    private void OnValidate()
    {
        if (GetComponent<Rigidbody>())
            _rigidbody = GetComponent<Rigidbody>();
    }
}
