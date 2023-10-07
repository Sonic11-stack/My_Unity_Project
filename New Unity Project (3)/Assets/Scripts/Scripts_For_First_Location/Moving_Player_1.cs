using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Player_1 : MonoBehaviour
{
    public float _speed = 6.0f;
    public float gravity = -1f;
    public CharacterController character;
    public static float speed = 7f;
    public bool shoot = false;
    void Start()
    {
        character = GetComponent<CharacterController>();
    }

    
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * _speed;
        float deltaZ = Input.GetAxis("Vertical") * _speed;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, _speed);
        movement.y = gravity;

        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        character.Move(movement);

        Controll();
    }
    public void Controll()
    {
        if (Input.GetMouseButton(1))
        {
            GetComponent<Animator>().Play("Attack_01");
            shoot = true;
        }

       /* if (Input.GetMouseButton(0) && shoot == true)
        {
            GetComponent<Animator>().Play("Attack");
            
        } */

        else
        {
            GetComponent<Animator>().Play("Staying");
            shoot = false;
        }
       /* if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Animator>().Play("Attack");
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Animator>().Play("Attack");
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Animator>().Play("Attack");
        } */
    }
}
