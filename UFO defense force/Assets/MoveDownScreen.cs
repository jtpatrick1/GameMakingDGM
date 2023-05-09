using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDownScreen : MonoBehaviour
{
    public int moveSpeed;
    void Update()
    {
        transform.Translate(Vector3.back * (Time.deltaTime * moveSpeed));
    }
}
