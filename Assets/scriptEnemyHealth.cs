using UnityEngine;

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

        if (anim != null)
        {
            anim.SetTrigger("enemyHit"); 
        }

        if (health <= 0)
        {
            Destroy(gameObject); 
        }
    }
}
