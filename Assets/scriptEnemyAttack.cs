using System;
using System.Collections;
using UnityEngine;

public class scriptEnemyAttack : MonoBehaviour
{
    public Collider2D attackHitbox;
    public int damage = 1;
    public Transform player;
    public float attackDuration = 2f;
    public float attackRange = 1f;

    public Boolean isAttacking = false;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        Debug.Log("Inimigo Performa Ataque + isAttacking: " + isAttacking);

        if (!isAttacking && Vector2.Distance(transform.position, player.position) <= attackRange)
        {
            StartCoroutine(PerformAttack());
        }
    }

    private IEnumerator PerformAttack()
    {
        isAttacking = true;

        attackHitbox.enabled = true;

        anim.SetBool("enemyAttack", true);

        yield return new WaitForSeconds(2f); 

        anim.SetBool("enemyAttack", false);

        attackHitbox.enabled = false;

        isAttacking = false;

    }
}
