using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Warrior : MonoBehaviour
{
    public static bool ter = false;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void Choose_Warrior()
    {
        ter = true;
        SceneManager.LoadScene("First_Location");
    }
}
