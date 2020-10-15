using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iSkIN : MonoBehaviour
{
    [SerializeField] Animator _animator;
    [SerializeField] Rigidbody[] _rigidbody;

    private void Start()
    {
        foreach (var rb in _rigidbody)
        {
            rb.isKinematic = true;
        }
    }

    private void Update()
    {
        if (!Input.GetKey(KeyCode.O)) return;

        _animator.enabled = false;
        foreach (var rb in _rigidbody)
        {
            rb.isKinematic = false;
        }
    }
}
