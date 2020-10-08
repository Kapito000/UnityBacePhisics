using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Прицел.
public class AimFlyter : MonoBehaviour
{
    [SerializeField] Collider[] _ignoreCollidres;
    [SerializeField] Transform _aimGO;

    [SerializeField] float _scaleAim = 0.2f;

    private void Awake()
    {

    }

    private void Update()
    {
        Ray ray = new Ray();
        //ray.origin = new Vector3(transform.position.x, transform.position.y, transform.position.z + 5);
        ray.origin = transform.position;
        ray.direction = transform.forward;

        //RaycastHit hit;
        if (Physics.Raycast(ray, out var hit))
        {
            _aimGO.position = hit.point;
            var distance = Vector3.Distance(transform.position, hit.point);
            _aimGO.localScale = Vector3.one * distance * _scaleAim;
        }

    }
}
