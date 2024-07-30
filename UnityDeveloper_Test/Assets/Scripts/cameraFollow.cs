using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform player;
    public float distance = 10f;
    public float height = 5f;
    public float smoothSpeed = 0.125f; 

    void LateUpdate()
    {
        if (player == null) return;
        Vector3 direction = -player.forward;
        Vector3 desiredPosition = player.position + direction * distance + Vector3.up * height;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
        transform.LookAt(player);
    }
}
