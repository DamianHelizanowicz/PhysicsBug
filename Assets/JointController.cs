using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointController : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private ConfigurableJoint joint;
    [SerializeField] private Transform pivotForDynamic;
    [SerializeField] private Transform pivot;
    [SerializeField] private Rigidbody pivotRigidbody;

    public void Attach()
    {
        transform.position = pivotForDynamic.position;
        transform.SetParent(pivot, true);

        Destroy(myRigidbody);

        joint.connectedBody = pivotRigidbody;
        joint.connectedAnchor = -Vector3.forward;
    }
}