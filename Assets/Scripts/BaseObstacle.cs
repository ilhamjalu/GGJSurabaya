using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Burst.CompilerServices;
using UnityEngine;

public abstract class BaseObstacle : MonoBehaviour
{
    public Vector2 startPos;
    public Vector2 endPos;
    public float speed;
    public float distance;

    public void SetStartPosition()
    {
        startPos = transform.position;
    }

    public void MoveObject()
    {
        transform.position = Vector3.MoveTowards(transform.position, endPos, speed * Time.deltaTime);
    }

    public void MoveToFirstPosition()
    {
        transform.position = Vector3.MoveTowards(transform.position, startPos, speed * Time.deltaTime);
    }

    public void PingPongMove()
    {
        float newPositionX = Mathf.PingPong(Time.time * speed, distance * 2) - distance;

        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);

    }
}
