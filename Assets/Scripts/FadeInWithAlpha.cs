using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInWithAlpha : FadeInBase
{
    protected override void OnSetup()
    {
        foreach (var c in GetComponentsInChildren<Graphic>())
            c.CrossFadeAlpha(0, 0, true);
    }
    protected override void OnFinish()
    {
        foreach (var c in GetComponentsInChildren<Graphic>())
            c.CrossFadeAlpha(1, 0, true);
    }
    protected override IEnumerator AnimFunc()
    {
        if (delay > 0)
            yield return new WaitForSeconds(delay);

        foreach (var c in GetComponentsInChildren<Graphic>())
        {
            c.CrossFadeAlpha(0, 0, true);
            c.CrossFadeAlpha(1, speedDuration, true);
        }

        yield return new WaitForSeconds(speedDuration);
    }
}
