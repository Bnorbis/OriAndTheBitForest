using UnityEngine;

public class scriptOriAttackHit : MonoBehaviour
{
    public int damage = 1;  

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Enemy"))
        {
            var enemyHealth = col.GetComponent<scriptEnemyHealth>();
            if (enemyHealth != null)
            {
                Debug.Log("Inimigo atingido! Aplicando dano: " + damage);
                enemyHealth.TakeDamage(damage);
            }
        }
    }
}
