using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Player : MonoBehaviour
{
    public static float speed = 7f;
    float mainSpeed = 100.0f; //regular speed
    float shiftAdd = 250.0f; //multiplied by how long shift is held.  Basically running
    float maxShift = 1000.0f; //Maximum speed when holdin gshift
    float camSens = 0.25f; //How sensitive it with mouse
    private Vector3 lastMouse = new Vector3(255, 255, 255); //kind of in the middle of the screen, rather than at the top (play)
    private float totalRun = 1.0f;

    public float _speed = 6.0f;
    public CharacterController character;

    void Start()
    {
        character = GetComponent<CharacterController>();
    }

    
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;
        float deltaZ = Input.GetAxis("Vertical") * _speed * Time.deltaTime;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, _speed);
        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        character.Move(movement);
        /* lastMouse = Input.mousePosition - lastMouse;
         lastMouse = new Vector3(-lastMouse.y * camSens, lastMouse.x * camSens, 0);
         lastMouse = new Vector3(transform.eulerAngles.x + lastMouse.x, transform.eulerAngles.y + lastMouse.y, 0);
         transform.eulerAngles = lastMouse;
         lastMouse = Input.mousePosition; */
         //Controlling_Player(); 
    }

    private void Controlling_Player()
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += -transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += -transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += transform.right * speed * Time.deltaTime;
        }
    } 
    
}
