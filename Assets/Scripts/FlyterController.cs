using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FlyterController : MonoBehaviour
{
    [SerializeField] float _deltaSpeed = 5;
    [SerializeField] float _speed = 30;
    [SerializeField] float _speedRotation = 5;
    [SerializeField] float _speedSideRotation = 1;
    [SerializeField] bool _boardRotation = true;

    Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        Additional();
    }

    private void Update()
    {
        _speed += Input.GetAxis("Mouse ScrollWheel") * _deltaSpeed;

        var moveSpeed = _speed;
        var moveZ = Input.GetAxis("Horizontal") * _speedSideRotation;
        var movePitch = Input.GetAxis("Vertical") * _speedRotation;

        var moveVector = new Vector3(0, 0, moveSpeed);
        var torqueZ = new Vector3(0, 0, moveZ);
        var torqueX = new Vector3(movePitch, 0, 0);

        _rigidbody.AddRelativeForce(moveVector, ForceMode.Impulse);
        _rigidbody.AddRelativeTorque(-torqueZ, ForceMode.Impulse);
        _rigidbody.AddRelativeTorque(torqueX, ForceMode.Impulse);

        Additional();
    }

    void Additional()
    {
        if (!_boardRotation) _rigidbody.maxAngularVelocity = Mathf.Infinity;
        if (_boardRotation) _rigidbody.maxAngularVelocity = _speedRotation;
    }
}
