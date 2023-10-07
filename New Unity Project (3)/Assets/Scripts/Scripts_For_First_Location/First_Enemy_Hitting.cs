using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class First_Enemy_Hitting : MonoBehaviour
{
    private int hit = 8;
    private int enemy_hp = 25;
    //public GameObject en;
    public float appear_of_coin;
    public GameObject icon_coin;
    public GameObject spawn_coin;
    public bool ver = false;
    public bool is_timer_more = false;
    public float timer_2 = 0f;
    public float timer_3 = 0f;
    void Start()
    {
        //en = GetComponent<GameObject>();
        icon_coin = GameObject.FindWithTag("re_coin");
        //spawn_coin = GetComponent<GameObject>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
             Destroy(this.gameObject);
             spawn_enemy.now_enemy--;
             spawn_enemy.count--;
             Spawn_Coin();
            //GetComponent<Animator>().Play("Attack");
            ver = true;
            
                //is_timer_more = true;
                //Check_Count_HP();
                /* if (Player.HP > hit)
                 {
                     Player.HP -= hit;
                 }
                 else
                 {
                     Player.HP = 0;

                 } */
                
            
         
        }
    }
     void Update()
    {
        switch (ver)
        {
            case true:
                ver = true;
                GetComponent<Animator>().Play("Attack");
                break;

            case false:
                ver = false;
                GetComponent<Animator>().Play("Walk");
                break;
        }
        switch (Follow_For_Player.bat)
        {
            case true:
                GetComponent<Animator>().Play("Stay");
                break;
            case false:
                Switch_Animation();
                break;
        }
        //Switch_Animation();
        
    }
    public void Spawn_Coin()
    {
        appear_of_coin = Random.Range(0, 101);
        if (appear_of_coin >= 5)
        {
            Vector3 temp = new Vector3(0, 1.0f, 0);
            Instantiate(icon_coin,this.transform.position += temp,Quaternion.identity);
        }

    }
    public void Switch_Animation()
    {
        if (ver == true)
        {
            Follow_For_Player.ver_1 = true;
            Switch_Time();
            if (timer_2 < 1.6f)
            {
                timer_2 += Time.deltaTime;
                //Switch_Time();
            }
            
            else
            {
                Follow_For_Player.ver_1 = false;
                ver = false;
                timer_2 = 0f;
                timer_3 = 0f;
                is_timer_more = false;
            }
        }
    }
    public void Switch_Time()
    { 
        if (is_timer_more == false)
        {
            if (timer_3 < 0.6f)
            {
                timer_3 += Time.deltaTime;
            }
            else if (timer_3 > 0.6f)
            {
                Check_Count_HP();
                is_timer_more = true;
                //timer_3 = 0f;
            }
        }
    }
    public void Check_Count_HP()
    {
       
        
            if (Player.HP > hit)
            {
                Player.HP -= hit;
            }
            else
            {
                Player.HP = 0;

            }
        
    }
}
