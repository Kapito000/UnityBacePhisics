using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateHole : MonoBehaviour
{
    [SerializeField] GameObject _hole = null;
    [SerializeField] float _life = 30;
    bool _isContact = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (_isContact) return;

        _isContact = true;
        var contactPoint = collision.GetContact(0);

        var hole = Instantiate(_hole, contactPoint.point, Quaternion.LookRotation(-contactPoint.normal));

        Destroy(hole, _life);
    }
}
