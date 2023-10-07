using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rage : MonoBehaviour
{
    public static GameObject rage;

    void Start()
    {
        rage = GameObject.FindWithTag("rage");
        rage.SetActive(false);
    }

    
    void Update()
    {
        
    }
}
