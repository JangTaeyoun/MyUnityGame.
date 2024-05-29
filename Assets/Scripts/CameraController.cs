using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Transform target;
    [SerializeField]
    private float minDistance = 3;
    [SerializeField]
    private float maxDistance = 30;
    [SerializeField]
    private float distance;
    private void LateUpdate()
    {
        if (target == null) return;
        transform.position = transform.rotation * new Vector3(0, 0, -distance) + target.position;
    }

    private float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360) angle += 360;
        if (angle > 360) angle -= 360;

        return Mathf.Clamp(angle, min, max);
    }
}
