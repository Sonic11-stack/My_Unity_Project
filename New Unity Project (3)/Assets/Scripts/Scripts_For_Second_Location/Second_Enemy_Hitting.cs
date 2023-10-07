using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Second_Enemy_Hitting : MonoBehaviour
{

    public class First_Enemy_Hitting : MonoBehaviour
    {
        private int hit_second_enemy = 12;
        private int enemy_hp_1 = 45;
        //public GameObject en;
        public float appear_of_coin_1;
        public GameObject icon_coin;
        public GameObject spawn_coin;
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

                if (Player.HP > hit_second_enemy)
                {
                    Player.HP -= hit_second_enemy;
                }
                else
                {
                    Player.HP = 0;

                }

            }
        }
        public void Spawn_Coin()
        {
            appear_of_coin_1 = Random.Range(0, 101);
            if (appear_of_coin_1 >= 5)
            {
                Instantiate(icon_coin, this.transform.position, Quaternion.identity);
            }

        }

    }

}
