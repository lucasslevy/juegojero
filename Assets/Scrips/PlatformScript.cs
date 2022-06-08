using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlatformScript : MonoBehaviour
{
    public float xSpeed;
    public float xLimitR;
    public float xLimitL;
    public bool toRight;

    public GameObject prefab1;
    public GameObject prefab2;
    public GameObject baseDer;
    public GameObject baseIzq;

    void Start()
    {
        toRight = true;
    }

    void Update()
    {
        if (toRight)
        {
            transform.position += new Vector3(xSpeed, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(xSpeed, 0, 0);
        }
        if (transform.position.x >= xLimitR)
        {
            toRight = false;
            GameObject clone;
            clone = Instantiate(prefab1);
            clone.transform.position = baseDer.transform.position + new Vector3(0, 1, 0);
        }
        else if (transform.position.x <= xLimitL)
        {
            toRight = true;
            GameObject clone;
            clone = Instantiate(prefab2);
            clone.transform.position = baseIzq.transform.position + new Vector3(0, 1, 0);

        }
    }
}
