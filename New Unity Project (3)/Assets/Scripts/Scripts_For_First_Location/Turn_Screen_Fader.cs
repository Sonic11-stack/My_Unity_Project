using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn_Screen_Fader : MonoBehaviour
{
    public GameObject vis;
    public float time = 3f;
    private bool check = false;
    
    void Start()
    {
        vis = GameObject.FindWithTag("vis");
        vis.SetActive(false);
    }

    
    void Update()
    {
        Stop();
        if (check == true)
        {
            time -= Time.deltaTime;
            if (time < 0)
            {
                time = 0f;
                vis.SetActive(true);
                check = false;
            }
        }
    }
    public void Stop()
    {
        if (Player.HP == 0)
            check = true;
    } 
}
