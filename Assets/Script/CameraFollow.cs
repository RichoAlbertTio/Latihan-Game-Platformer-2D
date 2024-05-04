using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform TargetCamera;
    public float SpeedCamera;
    public Vector3 Offset;

    void LateUpdate()
    {
        Vector3 positionCamera = TargetCamera.position + Offset;
        Vector3 SmoothCamera = Vector3.Lerp(transform.position, positionCamera, SpeedCamera * Time.deltaTime);
        transform.position = new Vector3(
            Mathf.Clamp(SmoothCamera.x, -6.6244f, 9.44f),
            Mathf.Clamp(SmoothCamera.y, 0f, 28f),
            SmoothCamera.z);
    }
}
