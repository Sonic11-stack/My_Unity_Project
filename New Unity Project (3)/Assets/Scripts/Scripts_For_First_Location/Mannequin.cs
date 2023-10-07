using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mannequin : MonoBehaviour
{
    public GameObject manne;
    public int count_of_manne = 1;
    public float time_go = 0f;
    GameObject clone;
    private bool m = true;
    private bool daw = true;
    public static bool bow = false;
    void Start()
    {
        //manne = GameObject.FindWithTag("mannequin");
        
    }

    
    void Update()
    {
        switch(m)
        {
            case true:
                Press_Q();
                break;
            case false:
                Destroy_Mannequin();
                break;
        }
    }
    public void Press_Q()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            bow = true;
            clone = Instantiate(manne, Follow_For_Player.player.transform.position+(transform.forward * 2), Quaternion.identity);
            count_of_manne--;
            m = false;
            
        }
    }
    public void Destroy_Mannequin()
    {
        
        if (time_go < 20f && daw == true)
        {
            time_go += Time.deltaTime;
        }

        else
        {
            Destroy(clone);
            bow = false;
            daw = false;
            //manne.SetActive(false);
            time_go = 0f;

        }
    }
 
}
