using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_enemy : MonoBehaviour
{
    public int count_of_enemy = 2;
    public static int now_enemy = 0;
    public static int count = 10;
    public GameObject[] enemies;
    public Transform[] spawn_points;
    public static spawn_enemy m;
    private int rand;
    private int rand_position;
    public float start_time_spawn;
    private float time_spawn;
    private bool j = false;
    //public bool b = false;
    //public GameObject r;
    
    void Start()
    {
        //spawn_points = new List<Transform>(spawn_points);
        //m = GameObject.FindWithTag("begin");
        //Spawn_First_Enemy();    
        //m = GetComponent<spawn_enemy>();
        //m.enabled= false;
        //r = GameObject.FindWithTag("begin");
        //r = GetComponent<GameObject>();

        //Spawn_First_Enemy();
        time_spawn = start_time_spawn;
    }

    
    void Update()
    {
        /*  if (GameObject.FindWithTag("area_of_totem") == null)
          {

              b = true;
              //Spawn_First_Enemy();

          }
          switch (b)
          {
              case true: 
                  r.SetActive(true);
                  Spawn_First_Enemy();
                  break;
              case false:
                  break;
          }
          //Spawn_After_Destroying(); */
        //Spawn_After_Destroying();


        //Spawn_First_Enemy();
        Sol();
    }
    void Spawn_First_Enemy()
    {
        
        //for (int i = 0; i < points.Length; i++)
        if (time_spawn <= 0 && now_enemy < count_of_enemy)
        {
            //var spawn = Random.Range(0,spawn_points.Count);
            //Instantiate(points[i], spawn_points[spawn].transform.position, Quaternion.identity);
            //spawn_points.RemoveAt(spawn);
            rand = Random.Range(0, enemies.Length);
            rand_position = Random.Range(0, spawn_points.Length);
            Instantiate(enemies[rand], spawn_points[rand_position].transform.position, Quaternion.identity);
            time_spawn = start_time_spawn;
            now_enemy++;
        }
        else 
        {
            time_spawn -= Time.deltaTime;
        }
    }
    public void Spawn_After_Destroying()
    {
        if (GameObject.FindWithTag("area_of_totem") == null)
        {

            //b = true;
            //r.SetActive(true);
            //Spawn_First_Enemy();
            //return;
            //Spawn_First_Enemy();
            
        }
    }
    public void Sol()
    {
        switch (count) {
            case 1:
                Spawn_First_Enemy();
                j = true;
                break;
        }
        if (j == false)
        {
            Spawn_First_Enemy();
        }

    }
}
