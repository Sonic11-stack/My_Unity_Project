using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

public class Time_For_Ability : MonoBehaviour
{
    public GameObject abil_1;
    public GameObject abil_2;
    public GameObject abil_3;
    public float time_abil = 30f;
    public float time_abil_1 = 0f;
    public float time_abil_2 = 0f;
    public Image time_bar;
    public Text time_text;
    public static bool time_for = false;

    void Start()
    {
        abil_1 = GameObject.FindWithTag("abil_1");
        abil_2 = GameObject.FindWithTag("abil_2");
        abil_3 = GameObject.FindWithTag("abil_3");
        time_bar = GameObject.FindGameObjectWithTag("dark_cube").GetComponent<Image>();
        time_text = GameObject.FindGameObjectWithTag("text_time").GetComponent<Text>();
        
        time_bar.enabled = false;
        time_text.enabled = false;
        abil_1.SetActive(false);
        abil_2.SetActive(false);
        abil_3.SetActive(false);

        switch (Wizard.pr)
        {
            case true:
                abil_2.SetActive(true);
                break;
        }
        switch (Archer.ger)
        {
            case true:
                abil_3.SetActive(true);
                break;
        }
        switch (Warrior.ter)
        {
            case true:
                abil_1.SetActive(true);
                break;
        }
    }

    
    void Update()
    {
        //time_bar.fillAmount =  time_abil / 30f;
        Timer_For_Ability_1();
    }
    public void Timer_For_Ability_1()
    {
        //if (Super_Ability.war == true || Super_Ability.arch == true || Super_Ability.wiz == true)
        if (Super_Ability.trew == true)
        {
            //time_bar.fillAmount = time_abil / 100f;
            time_for = true;
            time_bar.enabled = true;
            time_text.enabled = true;
            //if (time_for == true)
            //{
            if (time_abil_1 < 30f)
            {
                time_abil_2 += Time.deltaTime;
                time_abil_1 += Time.deltaTime;
                if (time_abil_2 >= 1f)
                {
                    time_abil -= 1;
                    time_text.text = Convert.ToString(time_abil);
                    time_abil_2 = 0f;
                }
            }

            /*if (time_abil_2 >= 1f)
            {
                time_abil -= 1;
                time_text.text = Convert.ToString(time_abil);
                time_abil_2 = 0f;
            } */
                
                else
                {
                    //Timer.has2 = true;
                    Super_Ability.trew = false;
                //Timer.has2 = false;
                    time_abil = 30f;
                    time_abil_1 = 0f;
                    time_for = false;
                    time_bar.enabled = false;
                    time_text.enabled = false;
                    
                }
            }
        //}
    }
}
