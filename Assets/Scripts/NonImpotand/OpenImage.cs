using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenImage : MonoBehaviour
{
    [SerializeField] Image _image;

    GameObject _imageGO;

    private void Awake()
    {
        _imageGO = _image.gameObject;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            _imageGO.SetActive(!_imageGO.activeSelf);
    }
}
