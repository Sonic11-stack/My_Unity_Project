using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Touch_The_Totem : MonoBehaviour
{
    public Text text;
    public GameObject tot;
    private bool checking = false;
    
    Follow_For_Player fol;
    void Start()
    {
        text = GameObject.FindGameObjectWithTag("totem").GetComponent<Text>();
        tot = GameObject.FindGameObjectWithTag("first_totem").GetComponent<GameObject>();
        text.enabled= false;
        
    }

    
    void Update()
    {
        switch (checking)
        {
            case true:
                Press_F();
                break;
                //return;
        }
       /* if (GameObject.FindWithTag("area_of_totem") == null) //&& GameObject.FindWithTag("first_totem") == null)
        {
            GetComponent<Follow_For_Player>().enabled = true;
            return;
        } */
        //Begin_Game();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            text.enabled = true;
            checking = true;
        }
       
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            text.enabled = false;
            checking = false;
        }
    }
    public void Press_F()
    {
        if (Input.GetKey(KeyCode.F))
        {
            Destroy(GameObject.FindWithTag("first_totem"));
            Destroy(GameObject.FindWithTag("area_of_totem"));
            //Destroy(GameObject.FindWithTag("Escape"));
            
            //turn_on_and_off_script.enabled = false;
            text.enabled = false;
            //spawn_enemy.m.enabled = true;
        }
    }
    public void Begin_Game()
    {

        if (GameObject.FindWithTag("area_of_totem") == null) //&& GameObject.FindWithTag("first_totem") == null)
        {
            GetComponent<Follow_For_Player>().enabled = true;
        }
    }
}
