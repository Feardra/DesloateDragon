using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Component Variables
    public Rigidbody2D rb;
    public Animator animator;
    #endregion

    #region Movement Variables
    public float moveSpeed = 5f;
    Vector2 movement;
    #endregion

    #region Movement Functions
    // Moves the player's rigidbody based on our movement variables
    private void Move()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
    #endregion

    #region Unity Functions
    // Update is called once per frame
    void Update()
    {
        // Get Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Set Animations
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    // FixedUpdate is called on a fixed timer
    private void FixedUpdate()
    {
        // Execute Player Movement
        Move();
    }
    #endregion
}
