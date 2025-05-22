using UnityEngine;

public class scriptOriAttackHit : MonoBehaviour
{
    public int damage = 1;  

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Atingiu");
        if (col.CompareTag("Enemy"))
        {
            var enemyHealth = col.GetComponent<scriptEnemyHealth>();
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(damage);
            }
        }
    }
}
