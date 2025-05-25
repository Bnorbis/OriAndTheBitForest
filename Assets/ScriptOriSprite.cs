using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ScriptOriSprite : MonoBehaviour
{
    private Rigidbody2D rbd;
    private Animator anim;
    public float vel;
    public float jump;
    private bool ground;
    public GameObject foot;
    public LayerMask mask;
    private bool oriRight = true;
    public GameObject canvasWin;


    void Start()
    {
        jump = 200;
        vel = 5;
        rbd = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        rbd.velocity = new Vector2(x * vel, rbd.velocity.y);

        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) && ground)
        {
            rbd.AddForce(new Vector2(0, jump));
        }
        anim.SetBool("jumping", !ground);


        if (x == 0)
        {
            anim.SetBool("moving", false);
        }
        else
        {
            anim.SetBool("moving", true);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("crouching", true);
        }
        else
        {
            anim.SetBool("crouching", false);
        }

        if (Input.GetKey(KeyCode.Z))
        {
            anim.SetBool("attacking", true);
        }
        else
        {
            anim.SetBool("attacking", false);
        }


        //Detecting direction
        if (x < 0 && oriRight || x > 0 && !oriRight)
        {
            transform.Rotate(new Vector2(0, 180));
            oriRight = !oriRight;
        }

        //Detecting ground 
        RaycastHit2D hit;

        hit = Physics2D.Raycast(foot.transform.position, Vector2.down, 0.4f, mask);

        if (hit.collider == null)
        {
            ground = false;
            transform.parent = null;
        }
        else
        {
            ground = true;
            transform.parent = hit.collider.transform;
        }

        }   
    
        private void OnCollisionEnter2D(Collision2D collision)
        {
            Debug.Log("Colidiu com: " + collision.gameObject.name);
            if (collision.gameObject.CompareTag("Win"))
        {
            canvasWin.SetActive(true);
        }
        }

}