using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KinematicMover : MonoBehaviour
{
    private void FixedUpdate()
    {
        float time = Time.time * 2.0f;

        transform.localPosition = new Vector3(
            Mathf.Sin(time),
            Mathf.Sin(time),
            -1.0f);
    }
}