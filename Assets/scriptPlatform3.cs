using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPlatform3 : MonoBehaviour
{
    private Vector2 posIni;
    public float amplitude = 1f;        
    public float speed = 1f;            
    private float cont = 0f;

    void Start()
    {
        posIni = transform.position;
    }

    void Update()
    {
        float y = Mathf.Sin(cont) * amplitude;

        transform.position = new Vector2(posIni.x, posIni.y + y);

        cont += speed * Time.deltaTime;

        if (cont > 2 * Mathf.PI)
        {
            cont = 0;
        }
    }
}
