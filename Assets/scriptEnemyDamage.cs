using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptEnemyDamage : MonoBehaviour
{
    public int damage;
    public scriptOriHealth scriptOriHealth;

    void Start()
    {
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ori")
        {
            scriptOriHealth.TakeDamage(damage);
        }
    }

    void Update()
    {
    }
}
