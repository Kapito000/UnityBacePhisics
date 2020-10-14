using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour
{
    [SerializeField] Camera _camera = null;
    [SerializeField] GameObject _shell = null;
    [SerializeField] int _speed = 10;

    private void Update()
    {
        if (!Input.GetMouseButtonDown(0)) return;

        var direction = _camera.ScreenPointToRay(Input.mousePosition).direction;
        var shell = Instantiate(_shell, transform.position, Quaternion.Euler(direction));
        var shellRB = shell.GetComponent<Rigidbody>().velocity = direction * _speed;

        Destroy(shell, 5f);
    }
}
