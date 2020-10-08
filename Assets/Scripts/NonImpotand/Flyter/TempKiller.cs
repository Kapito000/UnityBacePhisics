using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempKiller : MonoBehaviour
{
    [SerializeField] float _seconds = 3;

    void Start()
    {
        StartCoroutine(Kill(_seconds));
    }


    IEnumerator Kill(float seconds)
    {
        if (seconds < 1) seconds = 3;

        var elapse = 0f;
        do
        {
            elapse += Time.deltaTime;
            yield return null;
        }
        while (elapse < seconds);

        Destroy(gameObject);
        yield break;
    }
}
