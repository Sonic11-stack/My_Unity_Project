using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Super_Ability : MonoBehaviour
{
    public GameObject turn_on_and_off_player;
    public static bool war = false;
    public static bool wiz = false;
    public static bool arch = false;
    public static bool trew = false;
    //public float timer;
    //public float timer1 = 5f;

    void Start()
    {
        turn_on_and_off_player = GameObject.FindWithTag("Player");
    }


    void Update()
    {
        Press_E();
    }

    /*IEnumerator Press_E(float time_go = 5f)
    {
        if (Input.GetKey(KeyCode.E))
        {
            turn_on_and_off_player.SetActive(false);
            yield return new WaitForSeconds(time_go);
            //turn_on_and_off_player.SetActive(true);
        }
    } */
    public void Press_E()
    {
        if (Input.GetKey(KeyCode.E))
        {
            trew = true;
            if (Time_For_Ability.time_for == false) {
                Timer.has2 = true;
            }
            switch (Wizard.pr)
                 {
                     case true:
                         //Player.HP = 80;
                         wiz = true;
                         break;
                 }
                 switch (Archer.ger)
                 {
                     case true:
                         arch = true;
                         break;
                 }
                 switch (Warrior.ter)
                 {
                     case true:
                         war = true;
                         break;
                 } 
             } 
        }
    
      /*  public void Slow_Enemy()
        {

            //Follow_For_Player.speed = 1f;
            timer = timer1;
            if (timer <= timer1)
            {
                Player.hit_of_player *= 2;
                Follow_For_Player.speed = 1f;
                timer -= Time.deltaTime;
            }
            //if (timer > timer1)
            else
            {
                Player.hit_of_player /= 2;
                Follow_For_Player.speed = 2f;
            }

        } */
    }

