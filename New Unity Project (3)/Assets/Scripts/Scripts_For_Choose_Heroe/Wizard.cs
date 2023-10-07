using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wizard : MonoBehaviour
{
    public static bool pr = false;
    void Start()
    {
        
    }

  
    void Update()
    {
        
    }
    public void Choose_Wizard()
    {
        pr = true;
        SceneManager.LoadScene("First_Location");
    }
}
