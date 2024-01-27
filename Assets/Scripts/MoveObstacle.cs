using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacle : BaseObstacle
{
    public bool isMove;

    // Start is called before the first frame update
    void Start()
    {
        SetStartPosition();
    }

    // Update is called once per frame
    void Update()
    {
        if(isMove)
        {
            MoveObject();
        }
        else
        {
            MoveToFirstPosition();
        }
    }
}
