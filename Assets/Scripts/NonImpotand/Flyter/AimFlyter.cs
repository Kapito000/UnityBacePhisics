using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Прицел.
[ExecuteInEditMode]
public class AimFlyter : MonoBehaviour
{
    [SerializeField] Transform _aimGO = null;

    [SerializeField] float _scaleAim = 0.2f;


    RaycastHit _hit;
    public Vector3 Target
    {
        get
        {
            return _hit.point;
        }
    }

    private void Awake()
    {

    }

    private void Update()
    {
        Ray ray = new Ray();
        ray.origin = transform.position;
        ray.direction = transform.forward;

        if (Physics.Raycast(ray, out _hit))
        {
            _aimGO.position = _hit.point;
            var distance = Vector3.Distance(transform.position, _hit.point);
            _aimGO.localScale = Vector3.one * distance * _scaleAim;
        }
    }
}
