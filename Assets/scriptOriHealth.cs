using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptOriHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int health;

    Animator animator;

    void Start()
    {
        health = maxHealth;
        animator = GetComponent<Animator>();
    }

    public void TakeDamage(int damage)
    {
        StartCoroutine(TakeDamageCoroutine(damage));
    }

    private IEnumerator TakeDamageCoroutine(int damage)
    {
        health -= damage;
        animator.SetBool("hurting", true);
        yield return new WaitForSeconds(0.3f);
        animator.SetBool("hurting", false);

        if (health <= 0)
        {
            StartCoroutine(OriDeathAndDestroy());
        }
    }

    private IEnumerator OriDeathAndDestroy()
    {
        animator.SetTrigger("dying");
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
