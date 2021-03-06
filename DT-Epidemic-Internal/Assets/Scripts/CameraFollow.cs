﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    GameObject player;

    [SerializeField]
    int timeOffset;

    [SerializeField]
    Vector2 posOffset;

    //[SerializeField]
    //float leftLimit;

    //[SerializeField]
    //float rightLimit;

    //[SerializeField]
    //float topLimit;

    //[SerializeField]
    //float bottomLimit;

    private Vector3 velocity;

    void start()
    {

    }

    void update()
    {
        //Cameras current position
        Vector3 startPos = transform.position;

        //Players current position
        Debug.Log(player.transform.position);
        Vector3 endPos = player.transform.position;

        endPos.x += posOffset.x;
        endPos.y += posOffset.y;
        endPos.z = -10;

        //This is how you use Smooth Dampening
        //transform.position = Vector3.SmoothDamp(startPos, endPos, ref velocity, timeOffset);

        //This is how you Lerp
        transform.position = Vector3.Lerp(startPos, endPos, timeOffset * Time.deltaTime);

        //transform.position  = new Vector3
        //(
        //Mathf.Clamp(transform.position.x, leftLimit, rightLimit),
        //Mathf.Clamp(transform.position.y, topLimit, bottomLimit),
        //transform.position.z
        //);

        //void OnDrawGizmos()
        //{
        //    //Draw a box around our camera boundary
        //    Gizmos.color = Color.red;
        //    // Top boundary line
        //    Gizmos.DrawLine(new Vector2(leftLimit, topLimit), new Vector2(rightLimit, topLimit));
        //    //Right boundary line
        //    Gizmos.DrawLine(new Vector2(rightLimit, topLimit), new Vector2(rightLimit, bottomLimit));
        //    //Bottom boundary line
        //    Gizmos.DrawLine(new Vector2(rightLimit, bottomLimit), new Vector2(leftLimit, bottomLimit));
        //    //Left boundary line
        //    Gizmos.DrawLine(new Vector2(leftLimit, bottomLimit), new Vector2(leftLimit, topLimit));
        //}


    }

}

