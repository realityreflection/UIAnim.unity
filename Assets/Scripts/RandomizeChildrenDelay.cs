using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[DefaultExecutionOrder(-1000)]
[ExecuteInEditMode]
public class RandomizeChildrenDelay : MonoBehaviour
{
    public float min = 0.0f;
    public float max = 0.2f;
      
	void Awake()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            var anims = transform.GetChild(i).GetComponents<AnimBase>();

            var r = Random.Range(min, max); ;
            foreach (var anim in anims)
                anim.delay = r;
        }
    }
}
