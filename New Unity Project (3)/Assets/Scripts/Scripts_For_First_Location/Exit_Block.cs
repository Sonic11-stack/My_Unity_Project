using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit_Block : MonoBehaviour
{
    GameObject d;
    
    void Start()
    {
        d = GameObject.FindWithTag("exit_block");
        d.SetActive(false);
    }

    
    void Update()
    {
        Turn_Off();
    }
    public void Turn_Off ()
    {
        if (GameObject.FindWithTag("area_of_totem") == null)
        {
            d.SetActive(true);
            //GetComponent<spawn_enemy>().enabled = true;
        }
    }
   
}
