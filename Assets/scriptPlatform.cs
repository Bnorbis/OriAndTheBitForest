using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 posIni;
    public float displacement = 1;
    private float cont = 0;
    void Start()
    {
        posIni = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Sin(cont);
        float y = Mathf.Cos(cont);

        transform.position = new Vector2(posIni.x + x, posIni.y + y);

        cont = cont + displacement * Time.deltaTime;

        if (cont > 2 * Mathf.PI)
        {
            cont = 0;
        }

    }
}
