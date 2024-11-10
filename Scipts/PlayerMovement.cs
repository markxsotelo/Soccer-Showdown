using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float speed = 5f;
    private float jumpingPower = 6f;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    void Update() 
    {
        // Use A/D keys for horizontal movement
        horizontal = 0f; 

        if (Input.GetKey(KeyCode.A))  // Move left
        {
            horizontal = -1f;
        }
        if (Input.GetKey(KeyCode.D))  // Move right
        {
            horizontal = 1f;
        }

        // Jump with W key
        if (Input.GetKeyDown(KeyCode.W) && IsGrounded()) 
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpingPower); 
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontal * speed, rb.linearVelocity.y);
    }

    private bool IsGrounded() 
    {
        return Physics2D.OverlapCircle(groundCheck.position, .2f, groundLayer);
    }
}