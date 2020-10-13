using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetterMAs : MonoBehaviour
{
    [SerializeField] Camera _camera = null;

    private void Update()
    {
        if (!Input.GetMouseButton(0)) return;

        var ray = _camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out var hit))
        {
            if (!hit.collider.attachedRigidbody) return;
            var rb = hit.collider.attachedRigidbody;

            var newCentePos = new Vector3(hit.point.x, hit.point.y, rb.centerOfMass.z);
            newCentePos = hit.transform.InverseTransformPoint(newCentePos);
            rb.centerOfMass = Vector3.Scale(newCentePos, hit.transform.localScale);

            Debug.DrawLine(_camera.transform.position, hit.point, Color.blue);
            Debug.DrawLine(_camera.transform.position, new Vector3(hit.point.x, hit.point.y, rb.centerOfMass.z), Color.red);
        }
    }
}
