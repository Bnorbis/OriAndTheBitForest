using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptOriHealth : MonoBehaviour
{
    // Start is called before the first frame update
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
        health -= damage;
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
