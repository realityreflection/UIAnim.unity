using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInWithPosition : FadeInBase
{
    public Vector2 position;
    public bool isDeltaPosition;

    private Vector2 originalPosition;
    private RectTransform rt;

	void Awake()
    {
        rt = GetComponent<RectTransform>();

        originalPosition = rt.anchoredPosition;
    }

    protected override void OnSetup()
    {
        if (isDeltaPosition)
            rt.anchoredPosition = originalPosition + position;
        else
            rt.anchoredPosition = position;
    }

    protected override IEnumerator AnimFunc()
    {
        if (delay > 0)
            yield return new WaitForSeconds(delay);

        for (int i = 0;; i++)
        {
            rt.anchoredPosition +=
                (originalPosition - rt.anchoredPosition) * speedFactor;

            if (Vector2.Distance(rt.anchoredPosition, originalPosition) <= ErrorTolerance)
                break;

            yield return null;
        }

        rt.anchoredPosition = originalPosition;
    }
}
