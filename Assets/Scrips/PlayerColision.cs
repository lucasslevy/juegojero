using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerColision : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Obstaculo")
        {
            transform.position = new Vector3(0, 1, 0);
        }
        if (collision.gameObject.name == "DeathFloor")
        {
            transform.position = new Vector3(0, 1, 0);
        }
        if (collision.gameObject.name == "Meta")
        {
            SceneManager.LoadScene("You-Win");
        }
    }

}
