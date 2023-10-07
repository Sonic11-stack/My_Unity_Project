using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public GameObject portal;
    void Start()
    {
        portal = GameObject.FindWithTag("portal");
        
        portal.SetActive(false);
    }

    
    void Update()
    {
        Appear_Portal();
    }
    public void Appear_Portal()
    {
        switch (spawn_enemy.count)
        {
            case 0:
                portal.SetActive(true);
                break;
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player") {

            SceneManager.LoadScene("Second_Location");
        }
    }
}
