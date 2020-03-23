using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class add : MonoBehaviour
{


    public Rigidbody2D rb;
    public float vitesse;
    public float maxJump;
    private bool IsGrounded = false;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity += new Vector2(vitesse, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")&& IsGrounded)
        {
            Jump(); 
        }
    }

    void Jump()
    {
        rb.velocity += new Vector2(0, maxJump);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Ground"))
        {
            IsGrounded = true;
        }

    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            IsGrounded = false;
        }

    }

}

