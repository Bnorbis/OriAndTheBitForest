using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ori;
    public float offsetY;
    void Start()
    {
        offsetY = 3;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(ori.transform.position.x, ori.transform.position.y+offsetY, -10);
    }
}
