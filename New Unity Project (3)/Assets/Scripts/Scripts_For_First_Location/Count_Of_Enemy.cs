using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Count_Of_Enemy : MonoBehaviour
{
    public Text count_en;
    //public int count = 10;
    private bool signal;

    void Start()
    {
        count_en = GameObject.FindGameObjectWithTag("count_of_enemy").GetComponent<Text>();
        count_en.enabled = false;
        signal = false;
    }
        void Update()
        {
        Begin_Text();
        How_Much_Enemy();
        End_positive();
        }

    public void How_Much_Enemy()
    {
        
        //count = count - 1;
        count_en.text = Convert.ToString("Количество врагов:" + spawn_enemy.count);
        //signal = false;
    
    }
    public void Begin_Text()
    {
        if (GameObject.FindWithTag("area_of_totem") == null)
        {
            count_en.enabled = true;
        }
    }
    public void End_positive()
    {
        if (spawn_enemy.count == 0)
            count_en.enabled = false;
    }
}
