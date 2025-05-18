using UnityEngine;

public class scriptEnemyAttackHit : MonoBehaviour
{
    public int damage = 1;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Ori"))
        {
            var oriHealth = col.GetComponent<scriptOriHealth>();
            if (oriHealth != null)
                oriHealth.TakeDamage(damage);
        }
    }
}
