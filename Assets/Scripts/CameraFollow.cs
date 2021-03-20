using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;
    private float smoothSpeed = 0.08f;

    void Start()
    {
        target = GetComponent<Transform>().transform;
    }

    void Update()
    {
        Vector3 startPosition = new Vector3(target.position.x, transform.position.y, -1f);
        Vector3 smoothPosition = Vector3.Lerp(transform.position, startPosition, smoothSpeed);
        transform.position = smoothPosition;
    }
}
