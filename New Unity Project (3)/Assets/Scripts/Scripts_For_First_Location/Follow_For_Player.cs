using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Follow_For_Player : MonoBehaviour
{
    
    public static float speed = 1f;
    public static Transform player;
    public Follow_For_Player n;
    public Follow_For_Player z;
    public static bool ver_1 = false;
    public static bool bat = false;
    //public Animation anim;
    //public float time = 3f;
    //private bool check = false;
    //public GameObject vis;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        n = Follow_For_Player.FindObjectOfType<Follow_For_Player>();
        z = Follow_For_Player.FindObjectOfType<Follow_For_Player>();
        transform.LookAt(player);
        //anim = gameObject.GetComponent<Animation>();
        //anim = GetComponent<Animation>();
        //vis = GameObject.FindWithTag("vis");
        //vis.SetActive(false);

    }

    void Update()
    {
        switch (Mannequin.bow)
        {
            case false:
                player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
                break;

            case true:
                player = GameObject.FindGameObjectWithTag("mannequin").GetComponent<Transform>();
                break;
        }
        //player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        Stop_Enemy();
    /*    if (check == true)
        {
            time -= Time.deltaTime;
            if (time < 0)
            {
                time = 0f;
                vis.SetActive(true);
                check = false;
            }
        }  */
        //Begin_Game();
       // z.enabled= true;
    }
    void FixedUpdate()
    {
        //anim = GetComponent<Animation>();
        //anim.Play("ChestOpen");
        transform.LookAt(player);
        if (ver_1 == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.fixedDeltaTime);
        }
        
    }                                       
    public void Stop_Enemy()
    {
        if (Player.HP == 0) {
            speed = 0f;
            bat = true;
            //GetComponent<Animator>().Play("Stay");
            //check = true;
        }
    }
     public void Begin_Game()
    {
        if (GameObject.FindWithTag("area_of_totem") != null) 
        {
            //GetComponent<Follow_For_Player>().enabled = true;
            z.enabled = true;
        }
        

    }
  
}
