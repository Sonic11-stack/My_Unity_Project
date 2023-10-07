using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Game_Over : MonoBehaviour
{
    public Image image;
    public Text text;
    public Text text_1;
    public Text text_2;
    public Image image_2;
    public int count = Player.HP;
    

    void Start()
    {
        image = GetComponent<Image>();
        text = GetComponent<Text>();
        text_1 = GetComponent<Text>();
        //text_2 = GameObject.FindGameObjectWithTag("end_1").GetComponent<Text>();
        image_2 = GameObject.FindGameObjectWithTag("end").GetComponent<Image>();
        text_2 = GameObject.FindGameObjectWithTag("end_1").GetComponent<Text>();
        image_2.enabled = false;
        text_2.enabled = false;
    }


    void Update()
    {
        How_Much_Hp();
        End_Of_Game();
    }

    public void End_Of_Game()
    {
        if (Player.HP == 0)
        {
            image_2.enabled = true;
            text_2.enabled = true;
            
        }
    }
    public void How_Much_Hp()
    {
        count = Player.HP;
        text_1.text = Convert.ToString(count);

    }
   

}
