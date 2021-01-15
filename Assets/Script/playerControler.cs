using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour
{
    public float speed;
    private Vector2 direction;
    private Vector2 move;
    private Rigidbody2D rb2d;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        anim.SetFloat("Speed", rb2d.velocity.magnitude);
        if (Input.GetAxis("Horizontal") < 0)
        {
            direction = Vector2.left;
            move = Vector2.right;
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            direction = Vector2.right;
            move = Vector2.left;
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            direction = Vector2.down;
            move = Vector2.up;
        }
        else if (Input.GetAxis("Vertical") > 0)
        {
            direction = Vector2.up;
            move = Vector2.down;
        }
        rb2d.velocity = direction * speed;
        transform.up = move;
        if (rb2d.velocity.x == 0)
        {
            transform.position = new Vector2
            (Mathf.Round(transform.position.x), transform.position.y);
        }
        if (rb2d.velocity.y == 0)
        {
            transform.position = new Vector2(transform.position.x, Mathf.Round(transform.position.y));
        }
    }
}
