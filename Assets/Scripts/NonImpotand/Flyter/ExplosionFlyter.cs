using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ByteSheep.Events;

public class ExplosionFlyter : MonoBehaviour
{
    [SerializeField] float _radius = 10;
    [SerializeField] float _power = 10;
    [SerializeField] float _attenuation = 0.1f;
    [Space]
    [SerializeField] AimFlyter _aim = null;

    [SerializeField] QuickEvent _boom = null;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Fire(_aim.Target);
    }

    public void Fire(Vector3 positionExplosion)
    {
        var objs = Physics.OverlapSphere(positionExplosion, _radius);

        int i = 0;
        foreach (var obj in objs)
        {
            if (!obj.attachedRigidbody) continue;
            obj.attachedRigidbody.AddExplosionForce(_power - _attenuation * i, positionExplosion, _radius, _power, ForceMode.Impulse);
            i++;
        }
        _boom?.Invoke();
    }
}
