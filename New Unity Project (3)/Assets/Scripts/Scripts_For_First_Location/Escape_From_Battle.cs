using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escape_From_Battle : MonoBehaviour
{
    GameObject h;

    void Start()
    {
        h = GameObject.FindWithTag("Escape");
        h.SetActive(true);
    }


    void Update()
    {
        Turn_On();
    }
    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            QuitGame();
        }
    }
    public void Turn_On()
    {
        if (GameObject.FindWithTag("first_totem") == null)
        {
            h.SetActive(false);
        }
    } 
}
