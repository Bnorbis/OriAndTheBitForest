using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptOriDamage : MonoBehaviour
{
    public int damage;
    public scriptEnemyHealth scriptEnemyHealth;

    void Start()
    {
    }

    void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.tag == "Enemy")
    {
        scriptEnemyHealth enemyHealth = collision.gameObject.GetComponent<scriptEnemyHealth>();
        if (enemyHealth != null)
        {
            enemyHealth.TakeDamage(damage);
        }
    }
}


    void Update()
    {
    }
}
