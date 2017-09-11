using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOutBase : AnimBase
{
    public bool inactiveWhenDone = true;

    public void PlayFadeout()
    {
        StopAllCoroutines();

        OnSetup();
        StartCoroutine(AnimFunc());
    }
}
