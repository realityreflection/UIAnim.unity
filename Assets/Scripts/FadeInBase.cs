using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInBase : AnimBase
{
    void OnEnable()
    {
        PlayFadein();
    }

    public void PlayFadein()
    {
        StopAllCoroutines();

        OnSetup();
        StartCoroutine(AnimFunc());
    }
}
