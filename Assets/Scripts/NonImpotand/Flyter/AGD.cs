using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AGD : MonoBehaviour
{
    [SerializeField] AviaHorizon _aviaHorizon = null;

    [Space]

    [SerializeField] RectTransform _heel = null;
    [SerializeField] Text _pitch = null;

    private void FixedUpdate()
    {
        _heel.localRotation = Quaternion.AngleAxis(-_aviaHorizon.HeelAngle, Vector3.forward);
        _pitch.text = ((int)_aviaHorizon.PitchAngle).ToString();
    }
}