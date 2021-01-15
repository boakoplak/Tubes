using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") < 0)
        {
            rb2d.velocity = Vector2.left * speed;
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            rb2d.velocity = Vector2.right * speed;
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            rb2d.velocity = Vector2.down * speed;
        }
        else if (Input.GetAxis("Vertical") > 0)
        {
            rb2d.velocity = Vector2.up * speed;
        } 
    }
}
