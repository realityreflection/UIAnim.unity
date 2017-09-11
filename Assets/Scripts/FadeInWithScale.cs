﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInWithScale : FadeInBase
{
    public Vector3 initialScale;

    private Vector3 originalScale;

    void Awake()
    {
        originalScale = transform.localScale;
    }

    protected override void OnSetup()
    {
        transform.localScale = initialScale;
    }
    protected override IEnumerator AnimFunc()
    {
        if (delay > 0)
            yield return new WaitForSeconds(delay);

        for (int i = 0; i < 50; i++)
        {
            transform.localScale -=
                (transform.localScale - originalScale) * speedFactor;

            yield return null;
        }

        transform.localScale = originalScale;
    }
}
