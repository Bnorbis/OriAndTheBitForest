using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPlatform2 : MonoBehaviour
{
    private Vector2 posIni;
    public float displacement = 1f; 
    private float cont = 0f;
    public float speed = 1f; 

    void Start()
    {
        posIni = transform.position;
    }

    void Update()
    {
        float x = Mathf.Sin(cont); 
        transform.position = new Vector2(posIni.x + x * displacement, posIni.y);

        cont += speed * Time.deltaTime;

        if (cont > 2 * Mathf.PI) 
        {
            cont = 0f;
        }
    }
}
