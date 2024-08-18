using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraKontrol : MonoBehaviour
{
    public GameObject targetobject;
    public Vector3 cameraoffset;
    void LateUpdate()
    {
        transform.position = targetobject.transform.position + cameraoffset;
    }
}
