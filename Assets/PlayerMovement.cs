using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;



    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        // Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if(Input.GetAxisRaw("Horizontal") == 1)
        {
            animator.SetFloat("Horizontal", 1);
            animator.SetFloat("Vertical", 0);

        }
        else if(Input.GetAxisRaw("Horizontal") == -1)
        {
            animator.SetFloat("Horizontal", -1);
            animator.SetFloat("Vertical", 0);

        }
        else if(Input.GetAxisRaw("Vertical") == 1)
        {
            animator.SetFloat("Vertical", 1);
            animator.SetFloat("Horizontal", 0);

        }
        else if(Input.GetAxisRaw("Vertical") == -1)
        {
            animator.SetFloat("Vertical", -1);
            animator.SetFloat("Horizontal", 0);
        }

        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        // Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
