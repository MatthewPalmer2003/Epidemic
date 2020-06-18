using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrack : MonoBehaviour
{
    [SerializeField]
    GameObject player;

    [SerializeField]
    int timeOffset;

    [SerializeField]
    Vector2 posOffset;

    [SerializeField]
    float leftLimit, rightLimit, topLimit, bottomLimit;

    private Vector3 velocity;


    void Update()
    {
        // Cameras current position
        Vector3 startPos = transform.position;

        // Players current position
        Vector3 endPos = player.transform.position;

        // This is to offset the camera from the player
        endPos.x += posOffset.x;
        endPos.y += posOffset.y;
        endPos.z = -10;


        // This is how you Lerp
        transform.position = Vector3.Lerp(startPos, endPos, timeOffset * Time.deltaTime);


        // Sets the maximum and minimum position that the camera can move to. This is changes in the inspector inside unity.
        transform.position = new Vector3
        (
        Mathf.Clamp(transform.position.x, leftLimit, rightLimit),
        Mathf.Clamp(transform.position.y, bottomLimit, topLimit),
        transform.position.z
        );
    }

    private void OnDrawGizmos()
    {
        // Draw a box around our camera boundary
        Gizmos.color = Color.red;
        // Top boundary line
        Gizmos.DrawLine(new Vector2(leftLimit, topLimit), new Vector2(rightLimit, topLimit));
        // Right boundary line
        Gizmos.DrawLine(new Vector2(rightLimit, topLimit), new Vector2(rightLimit, bottomLimit));
        // Bottom boundary line
        Gizmos.DrawLine(new Vector2(rightLimit, bottomLimit), new Vector2(leftLimit, bottomLimit));
        // Left boundary line
        Gizmos.DrawLine(new Vector2(leftLimit, bottomLimit), new Vector2(leftLimit, topLimit));
    }
}
