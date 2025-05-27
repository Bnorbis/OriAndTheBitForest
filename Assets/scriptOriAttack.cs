using UnityEngine;
using System.Collections;
using System;


public class scriptOriAttack : MonoBehaviour
{
    public Collider2D attackHitbox;     
    public float attackDuration = 0.3f; 

    private bool isAttacking = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && !isAttacking)
        {
        Debug.Log("Atacou o inimigo!");
            StartCoroutine(PerformAttack());
        }
    }

    private IEnumerator PerformAttack()
    {
        isAttacking = true;
        attackHitbox.enabled = true;           
        yield return new WaitForSeconds(attackDuration);
        attackHitbox.enabled = false;          
        isAttacking = false;
    }
}
