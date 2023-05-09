using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveForward : MonoBehaviour
{
    public int bulletMoveSpeed;
    public int bulletBarrier;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector3.down * (Time.deltaTime * bulletMoveSpeed));
        if (transform.position[2] >= bulletBarrier)
        {
            Destroy(gameObject);
        }
    }
}
