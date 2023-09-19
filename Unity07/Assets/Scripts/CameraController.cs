using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform ballTransform;
    public float followHeight = 1f;

    void LateUpdate()
    {
        Vector3 targetPosition = new Vector3(ballTransform.position.x +2f, ballTransform.position.y + followHeight, ballTransform.position.z);
        transform.position = targetPosition;
        transform.LookAt(ballTransform.position);
    }
}
