using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Coin : MonoBehaviour
{
    public static int coins = 0;
    public Text count_of_coins;
    void Start()
    {
        count_of_coins = GameObject.FindGameObjectWithTag("coins").GetComponent<Text>();
    }

    
    void Update()
    {
            count_of_coins.text = Convert.ToString(coins);
       
    }
    
}
