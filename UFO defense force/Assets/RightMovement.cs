using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RightMovement : MonoBehaviour
{
    public int rightMoveSpeed;
    public int rightBarrierValue;
    public void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
                
            transform.Translate(Vector3.right * (Time.deltaTime * rightMoveSpeed));
            var transformPosition = GameObject.Find("Player").transform.position;
            if (transform.position[0] >= rightBarrierValue)
            {
                rightMoveSpeed = 0;
            }
            if (transform.position[0] <= rightBarrierValue)
            {
                rightMoveSpeed = 10;
            }
        }
    }
}
