using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInWithFill : FadeInBase
{
    private Image image;

    private float originalFill;

	void Awake()
    {
        image = GetComponent<Image>();

        originalFill = image.fillAmount;
    }

    protected override void OnSetup()
    {
        image.fillAmount = 0;
    }
    protected override IEnumerator AnimFunc()
    {
        if (delay > 0)
            yield return new WaitForSeconds(delay);

        for (int i = 0;; i++)
        {
            image.fillAmount -=
                (image.fillAmount - originalFill) * speedFactor;

            if (Mathf.Abs(image.fillAmount - originalFill) <= ErrorTolerance)
                break;

            yield return null;
        }

        image.fillAmount = originalFill;
    }
}
 