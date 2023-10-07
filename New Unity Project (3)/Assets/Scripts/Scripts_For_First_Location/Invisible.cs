using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisible : MonoBehaviour
{
    public static GameObject invis;
    void Start()
    {
        invis = GameObject.FindWithTag("invisible");
        invis.SetActive(false);
    }

    
    void Update()
    {
        
    }
}
