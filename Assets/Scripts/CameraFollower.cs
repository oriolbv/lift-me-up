using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public GameObject targetObject;

    private float distanceToTarget;

    void Start()
    {
        distanceToTarget = transform.position.y - targetObject.transform.position.y;
    }

    void Update()
    {
        float targetObjectY = targetObject.transform.position.y;
        Vector3 newCameraPosition = transform.position;
        newCameraPosition.y = targetObjectY + distanceToTarget;
        transform.position = newCameraPosition;
    }
}
