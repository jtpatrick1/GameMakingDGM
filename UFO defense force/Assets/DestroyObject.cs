using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public Object mainObject;
    void Start()
    {
        mainObject = GetComponent<Rigidbody>();
    }

    public void DestoryMainObject()
    {
        Destroy(mainObject);
    }
}
