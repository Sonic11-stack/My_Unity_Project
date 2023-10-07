using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Victory : MonoBehaviour
{
    public Text vict;
    public static bool solution;
    void Start()
    {
        vict = GameObject.FindGameObjectWithTag("victory").GetComponent<Text>();
        vict.enabled = false;
    }

    
    void Update()
    {
        Vic();
    }
    public void Vic()
    {
        switch(spawn_enemy.count)
        {
            case 0:
                vict.enabled = true;
                break;
        }
    }
}
