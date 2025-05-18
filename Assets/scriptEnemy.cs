using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2f;
    private Rigidbody2D rb;
    private Vector2 direction = Vector2.right;
    Animator animator;


    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = direction * speed;
        animator.SetBool("enemyWalking", rb.velocity.x != 0);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        direction *= -1;

        Vector3 scale = transform.localScale;
        if ((direction.x > 0 && scale.x < 0) || (direction.x < 0 && scale.x > 0))
        {
            scale.x *= -1;
            transform.localScale = scale;
        }
    }
}
