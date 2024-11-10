using UnityEngine;

public class AIController : MonoBehaviour
{
    private float speed = 5f;           
    private float jumpingPower = 6f;    

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        float horizontal = 0f;

        // Left arrow for left movement
        if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            horizontal = -1f;
        }

        // Right arrow for right movement
        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            horizontal = 1f;
        }

        rb.linearVelocity = new Vector2(horizontal * speed, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.UpArrow) && IsGrounded()) 
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpingPower); 
        }
    }

    private bool IsGrounded() 
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
}