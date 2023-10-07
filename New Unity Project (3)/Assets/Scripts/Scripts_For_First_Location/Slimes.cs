using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Slimes : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Moving_Player.speed -= 3f;
        }
    }
    private void OnCollisionExit (Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Moving_Player.speed += 3f;
        }
    }
}
