using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;
public class Coins_1 : MonoBehaviour
{
    
    public Text count_of_coins_1;
    void Start()
    {
        count_of_coins_1 = GameObject.FindGameObjectWithTag("coins_1").GetComponent<Text>();
    }

    
    void Update()
    {
        if (Coin.coins == 0 || Coin.coins >= 10 && Coin.coins <= 20 || Coin.coins % 10 >= 5)
        {
            count_of_coins_1.text = Convert.ToString("монет");
        }
        else if (Coin.coins == 1 || Coin.coins % 10 == 1)
        {
            count_of_coins_1.text = Convert.ToString("монета");
        }
        else if (Coin.coins % 10 <= 4)
        {
            count_of_coins_1.text = Convert.ToString("монеты");
        }
    }
}
