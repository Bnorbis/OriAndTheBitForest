using UnityEngine;
using System.Collections;

public class scriptEnemyHealth : MonoBehaviour
{
    public int maxHealth = 5;
    private int health;
    private Animator anim;

    void Start()
    {
        health = maxHealth;
        anim = GetComponent<Animator>();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        StartCoroutine(PlayHitAnimation());

        if (health <= 0)
        {
            StartCoroutine(Die());
        }
    }

    private IEnumerator Die()
    {
        if (anim != null)
        {
            anim.SetTrigger("enemyDeath");
            yield return new WaitForSeconds(0.5f);
        }
        Destroy(gameObject);
    }

    private IEnumerator PlayHitAnimation()
    {
        if (anim != null)
        {
            anim.SetBool("enemyHit", true);
            yield return new WaitForSeconds(0.5f);
            anim.SetBool("enemyHit", false);
        }
    }
}
