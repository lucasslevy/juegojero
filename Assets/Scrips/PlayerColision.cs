using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerColision : MonoBehaviour
{
    public Vector3 posInicio;

    // Start is called before the first frame update
    void Start()
    {
        posInicio = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Obstaculo")
        {
            transform.position = posInicio;
        }
        if (collision.gameObject.name == "DeathFloor")
        {
            transform.position = new Vector3(-29, 2.2f, 26.2f);
        }
        if (collision.gameObject.name == "Meta")
        {
            SceneManager.LoadScene("You-Win");
        }
    }

}
