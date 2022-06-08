using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float MovementSpeed = 0.1f;
    float RotationSpeed = 4;
    public float jumpForce = 5;
    public int maxJumps = 2;

    public int hasJump;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        hasJump = maxJumps;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, MovementSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -MovementSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, RotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -RotationSpeed, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space) && hasJump > 0)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            hasJump--;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Ground")
        {
            hasJump = 2;
        }
    }
}