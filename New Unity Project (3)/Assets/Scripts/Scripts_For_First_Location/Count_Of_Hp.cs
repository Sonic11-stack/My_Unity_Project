using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count_Of_Hp : MonoBehaviour
{
    public GameObject count_hp_1;
    public GameObject count_hp_2;
    public GameObject count_hp_3;

    void Start()
    {
        count_hp_1 = GameObject.FindWithTag("count(1)");
        count_hp_2 = GameObject.FindWithTag("count(2)");
        count_hp_3 = GameObject.FindWithTag("count(3)");

        count_hp_1.SetActive(false);
        count_hp_2.SetActive(false);
        count_hp_3.SetActive(false);
    }

    
    void Update()
    {
        Show_Text();
    }
    public void Show_Text()
    {
        switch(Wizard.pr)
        {
            case true:
                count_hp_2.SetActive(true);
                break;
        }
        switch (Archer.ger)
        {
            case true:
                count_hp_3.SetActive(true);
                break;
        }
        switch (Warrior.ter)
        {
            case true:
                count_hp_1.SetActive(true);
                break;
        }
    }
}
