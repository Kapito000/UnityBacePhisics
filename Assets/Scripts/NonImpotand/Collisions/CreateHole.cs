using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateHole : MonoBehaviour
{
    [SerializeField] GameObject _hole = null;

    private void OnCollisionEnter(Collision collision)
    {
        var contactPoint = collision.GetContact(0);

        var hole = Instantiate(_hole, contactPoint.point, Quaternion.LookRotation(-contactPoint.normal));

        Destroy(hole, 5);
    }
}
