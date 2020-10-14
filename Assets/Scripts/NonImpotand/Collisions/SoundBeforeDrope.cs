using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBeforeDrope : MonoBehaviour
{
    AudioSource _audioSource;


    private void OnCollisionEnter(Collision collision)
    {
        if (_audioSource.isPlaying) return;
        _audioSource.volume = collision.impulse.magnitude * 0.01f;
        _audioSource.Play();
    }

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }
}
