using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public float moveSpeed = 8f;
    private float horizontalInput;
    private bool isFacingRight = true;

    [Header("Jumping")]
    public float jumpForce = 12f;
    public Transform groundCheck;     
    public LayerMask groundLayer;     
    public float checkRadius = 0.2f;  
    private bool isGrounded;

    private Rigidbody2D rb;

    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        horizontalInput = Input.GetAxisRaw("Horizontal");

        
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundLayer);

        
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        CheckFlip();
    }

    void FixedUpdate()
    {
        
        rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
    }

    void CheckFlip()
    {
        
        if (horizontalInput > 0 && !isFacingRight)
        {
            Flip();
        }
        
        else if (horizontalInput < 0 && isFacingRight)
        {
            Flip();
        }
    }

    void Flip()
    {
        isFacingRight = !isFacingRight;
        
        Vector3 currentScale = transform.localScale;
        
        currentScale.x *= -1;

        transform.localScale = currentScale;
    }

    
    private void OnDrawGizmosSelected()
    {
        if (groundCheck != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(groundCheck.position, checkRadius);
        }
    }
}
