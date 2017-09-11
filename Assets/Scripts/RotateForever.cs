using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateForever : MonoBehaviour
{
    public Vector3 speed;
    public float multiplier = 1;

	void Update ()
    {
        transform.Rotate(speed * Time.deltaTime * multiplier);
	}
}
