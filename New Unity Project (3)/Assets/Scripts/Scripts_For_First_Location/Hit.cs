using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hit : MonoBehaviour
{
    public Image healthBar;
    public Player player;

    void Start()
    {
        healthBar = GetComponent<Image>();
        player = FindObjectOfType<Player>();
    }


    void Update()
    {
        healthBar.fillAmount = Player.HP / 100f;
    }

}
