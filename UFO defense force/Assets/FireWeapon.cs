using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class FireWeapon : MonoBehaviour
{
    public GameObject Bullet;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp((int)MouseButton.LeftMouse))
        {
            Instantiate(Bullet, transform.position, Bullet.transform.rotation);
            
        }
    }
}


