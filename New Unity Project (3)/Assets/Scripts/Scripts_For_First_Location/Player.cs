using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private static float player_hp = 10f;
    public static float hit_of_player; 
    //public Image healthBar;
    

    void Start()
    {
       // healthBar = GetComponent<Image>();
       Get_HP();

    }
    void Update()
    {
        //healthBar.fillAmount = player_hp / 100;
        
    }
   public static int HP
    {
        get { return (int)player_hp; }
        set
        {
            player_hp = value;
            Debug.LogFormat("Lives: {0}", player_hp);
        }
    } 

   

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Escape")
        {
            Debug.Log("YEEEEEE");
            
        }
       if (collision.gameObject.tag == "Enemy")
        {

        }
    }
    public void Get_HP()
    {
        switch (Wizard.pr)
        {
            case true:
                player_hp = 80f;
                hit_of_player = 10;
                break;
        }
        switch (Archer.ger)
        {
            case true:
                player_hp = 60f;
                hit_of_player = 20;
                break;
        }
        switch (Warrior.ter)
        {
            case true:
                player_hp = 100f;
                hit_of_player = 15;
                break;
        }
    }


}
