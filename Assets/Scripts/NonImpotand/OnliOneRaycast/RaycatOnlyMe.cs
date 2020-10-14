using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycatOnlyMe : MonoBehaviour
{
    [SerializeField] Camera _camera = null;

    void Update()
    {
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

        if (GetComponent<Collider>().Raycast(ray, out var hit, 100f))
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
    }
}
