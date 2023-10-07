using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        Attack_To_Enemy();
    }
    public void Attack_To_Enemy()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.Play("Attack_01");
        }
    }
}
