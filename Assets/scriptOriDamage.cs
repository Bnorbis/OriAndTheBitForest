using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptOriDamage : MonoBehaviour
{
    public int damage;
    public scriptOriHealth scriptOriHealth;
    Animator animator;



    void Start()
    {
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            scriptOriHealth oriHealth = collision.gameObject.GetComponent<scriptOriHealth>();
            if (oriHealth != null)
            {
                oriHealth.TakeDamage(damage);
                animator.SetBool("hurting", true);
                Console.WriteLine(animator.GetBool("hurting"));

            }
        }
    }


    void Update()
    {
    }
}
