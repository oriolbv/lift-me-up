using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public GameObject targetObject;

    void Start()
    {
        
    }

    void Update()
    {
        float targetObjectY = targetObject.transform.position.y;
        Vector3 newCameraPosition = transform.position;
        newCameraPosition.y = targetObjectY;
        transform.position = newCameraPosition;
    }
}
