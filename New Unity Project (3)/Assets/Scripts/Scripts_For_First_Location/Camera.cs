using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float mouse_sensivity = 100f;
    public GameObject player_1;
    void Update()
    {
        transform.Rotate(Input.GetAxis("Mouse Y") * Time.deltaTime * mouse_sensivity, 0, 0);
        player_1.transform.Rotate(0, Input.GetAxis("Mouse X") * Time.deltaTime * mouse_sensivity, 0);
    }
}
