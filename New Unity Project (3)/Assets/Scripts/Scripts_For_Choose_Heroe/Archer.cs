using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Archer : MonoBehaviour
{
    public static bool ger = false;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void Choose_Archer()
    {
        ger = true;
        SceneManager.LoadScene("First_Location");
    }
}
