using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public 

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void Open_Main_Game()
    {
        SceneManager.LoadScene("Choose_Hero");
    }
    public void Close_Game()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
    public void Settings_Of_Game()
    {

    }
}
