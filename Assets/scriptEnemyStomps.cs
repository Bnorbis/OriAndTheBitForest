using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptEnemyStomps : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "WeakPoint") {
            Destroy(collision.gameObject);
        }
    }
}
