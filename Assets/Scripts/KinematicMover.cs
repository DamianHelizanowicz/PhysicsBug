using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KinematicMover : MonoBehaviour
{
    [SerializeField] private float zDistance = -1.0f;

    private void FixedUpdate()
    {
        float time = Time.time * 2.0f;

        transform.localPosition = new Vector3(
            Mathf.Sin(time) * 0.5f,
            Mathf.Sin(time),
            zDistance);
    }
}