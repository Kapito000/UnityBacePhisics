using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// АГД
public class AviaHorizon : MonoBehaviour
{
    [Header("Положение горизонта.")]
    [SerializeField] float _pitchHorizon = 0;
    [SerializeField] float _heelHorizon = 0;
    [Space]
    [SerializeField] float _pitchAngle = 0; // Тангаж.
    [SerializeField] float _heelAngle = 0; // Крен.

    [SerializeField] Transform _flyter;

    private void Awake()
    {
        if (!_flyter && GetComponent<Transform>()) _flyter = transform;
    }

    private void FixedUpdate()
    {
        if (_flyter.localRotation.eulerAngles.x > 90)
        {
            var _flyterX = 360 - _flyter.localRotation.eulerAngles.x;
            _pitchAngle = _flyterX;
        }
        else _pitchAngle = _pitchHorizon - _flyter.localRotation.eulerAngles.x;


        if (_flyter.localRotation.eulerAngles.z > 180)
        {
            var _flyterX = 360 - _flyter.localRotation.eulerAngles.z;
            _heelAngle = _flyterX;
        }
        else _heelAngle = _heelHorizon - _flyter.localRotation.eulerAngles.z;
    }
}
