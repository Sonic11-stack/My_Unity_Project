using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Camera : MonoBehaviour
{
    [SerializeField] Transform pivot;
    void Start()
    {
        
    }

    
    void Update()
    {
        Vector2 axis;
        Transform cam;
        axis.x = Input.GetAxis("Mouse X");
        axis.y = -Input.GetAxis("Mouse Y");
        transform.Rotate(0, axis.x, 0);
        cam = UnityEngine.Camera.main.transform;
        cam.RotateAround(transform.position, transform.up, axis.x);
        cam.RotateAround(pivot.position, pivot.right, axis.y);
    }
}
