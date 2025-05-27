using UnityEngine;

public class scriptOriDamage : MonoBehaviour
{
    public int damage;
    public scriptOriHealth scriptOriHealth;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (scriptOriHealth != null)
            {
                scriptOriHealth.TakeDamage(damage);
                animator.SetBool("hurting", true);
                Debug.Log("Ori tomou dano de inimigo!");
            }
        }
    }

    void Update()
    {
      
    }
}
