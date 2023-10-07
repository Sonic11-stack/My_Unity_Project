using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Empty_Strip : MonoBehaviour
{

    public Image strip;
    public Player play;

    void Start()
    {
        strip = GetComponent<Image>();
        //strip.fillAmount = Player.HP;
        play = FindObjectOfType<Player>();
        strip.fillAmount = Player.HP / 100f;
    }


    void Update()
    {
        //strip.fillAmount = Player.HP / 100f;
    }

}
