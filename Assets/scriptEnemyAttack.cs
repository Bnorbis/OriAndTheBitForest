using System.Collections;
using UnityEngine;

public class scriptEnemyAttack : MonoBehaviour
{
    public Collider2D attackHitbox;
    public int damage = 1;
    public float attackDuration = 0.5f;
    public float attackRange = 1.5f;
    public Transform player;
    
    private bool isAttacking = false;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (!isAttacking && Vector2.Distance(transform.position, player.position) <= attackRange)
        {
            StartCoroutine(PerformAttack());
        }
    }

    private IEnumerator PerformAttack()
    {
        isAttacking = true;

        if (anim != null)
            anim.SetTrigger("enemyAttack");

        attackHitbox.enabled = true;

        yield return new WaitForSeconds(attackDuration);

        attackHitbox.enabled = false;
        isAttacking = false;
    }
}
