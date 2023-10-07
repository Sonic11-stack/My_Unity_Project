using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn_Spawns : MonoBehaviour
{
    public GameObject turn_spawn;

    void Start()
    {
        turn_spawn = GameObject.FindWithTag("begin");
        turn_spawn.SetActive(false);

    }


    void Update()
    {
        Check_Spawn();
    }
    public void Check_Spawn ()
    {

        if (GameObject.FindWithTag("area_of_totem") == null) 
        {
            turn_spawn.SetActive(true);
            
        }
    }
}
