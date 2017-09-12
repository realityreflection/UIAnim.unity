using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimBase : MonoBehaviour
{
    public float delay = 0.0f;
    public AnimSpeed speed = AnimSpeed.Normal;

    protected static readonly float ErrorTolerance = 0.01f;

    protected float speedFactor
    {
        get
        {
            switch (speed)
            {
                case AnimSpeed.Normal:
                    return 0.15f;
                case AnimSpeed.Fast:
                    return 0.17f;
                case AnimSpeed.Slow:
                    return 0.05f;
            }
            return 0.01f;
        }
    }
    protected float speedDuration
    {
        get
        {
            switch (speed)
            {
                case AnimSpeed.Normal:
                    return 0.25f;
                case AnimSpeed.Fast:
                    return 0.10f;
                case AnimSpeed.Slow:
                    return 0.35f;
                case AnimSpeed.ExtraSlow:
                    return 1.0f;
            }
            return 0.01f;
        }
    }

    protected virtual void OnSetup()
    {
    }
    protected virtual void OnFinish()
    {
    }
    protected virtual IEnumerator AnimFunc()
    {
        yield return null;
    }

    public void ForceFinish()
    {
        StopAllCoroutines();
        OnFinish();
    }
}
