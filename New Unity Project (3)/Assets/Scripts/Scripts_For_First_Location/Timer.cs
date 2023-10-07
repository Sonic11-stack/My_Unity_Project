using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timer = 0f;
    public float timer1 = 5f;
    private bool has = false;
    public static bool has2 = true;
    void Start()
    {
        
    }

    
    void Update()
    {
        Slow_Enemy();
        Player_Invisible();
        Player_Heal();
    }
    public void Slow_Enemy()
    {
        if (Super_Ability.war == true && has2 == true)
        {
            if (timer < 5f)
            {
                Rage.rage.SetActive(true);
                Player.hit_of_player *= 2;
                Follow_For_Player.speed = 1f;
                timer += Time.deltaTime;
            }
            //if (timer > timer1)
            else
            {
                Rage.rage.SetActive(false);
                Player.hit_of_player /= 2;
                Follow_For_Player.speed = 2f;
                timer = 0f;
                has2 = false;
            }
        }
    }
    public void Player_Invisible()
    {
        if (Super_Ability.arch == true && has2 == true)
        {
            if (timer < 5f)
            {
                Invisible.invis.SetActive(true);
                Follow_For_Player.speed = 0f;
                timer += Time.deltaTime;
            }
            
            else
            {
                Invisible.invis.SetActive(false);
                Follow_For_Player.speed = 2f;
                timer = 0f;
                has2 = false;
            }
            
        }
    }
    public void Player_Heal()
    {
        if (has == false)
        {
            if (Super_Ability.wiz == true)
            {
                Player.HP = 80;
                has = true;
            }
        }
    }
}
