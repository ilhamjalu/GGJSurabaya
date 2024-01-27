using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongObstacle : BaseObstacle
{
    // Start is called before the first frame update
    void Start()
    {
        SetStartPosition();
    }

    // Update is called once per frame
    void Update()
    {
        PingPongMove();
    }
}
