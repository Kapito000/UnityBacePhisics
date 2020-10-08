using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomAudioCreator : MonoBehaviour
{
    [SerializeField] GameObject _audioPrefab;
    [SerializeField] AudioClip[] _audioClips;

    public void Create()
    {
        var audioInstance = Instantiate(_audioPrefab, transform.position, Quaternion.identity, transform);

        var indexClip = Random.Range(0, _audioClips.Length);
        audioInstance.GetComponent<AudioSource>().clip = _audioClips[indexClip];
        audioInstance.GetComponent<AudioSource>().Play();
    }
}
