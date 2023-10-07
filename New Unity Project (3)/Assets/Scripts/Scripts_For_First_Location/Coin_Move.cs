using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Coin_Move : MonoBehaviour
{
  
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(0, 1, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            Coin.coins++;
        }
    }
   
}
