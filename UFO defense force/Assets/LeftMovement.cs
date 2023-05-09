using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMovement : MonoBehaviour
{
    public int leftMoveSpeed = 10;
    public int leftBarrierValue;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {

            transform.Translate(Vector3.left * (Time.deltaTime * leftMoveSpeed));
            var transformPosition = GameObject.Find("Player").transform.position;
            if (transform.position[0] <= leftBarrierValue)
            {
                leftMoveSpeed = 0;
            }

            if (transform.position[0] >= leftBarrierValue)
            {
                leftMoveSpeed = 10;
            }
        }
    }
}
