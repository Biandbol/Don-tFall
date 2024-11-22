using UnityEngine;

public class move : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float jumpForce = 8.0f; // Adjust the jump force as needed
    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Check if the player is grounded (you should set up your own grounded check)
        isGrounded = CheckGrounded();

        // Get input for movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement direction
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput).normalized;

        // Apply the movement to the Rigidbody
        rb.velocity = new Vector3(movement.x * moveSpeed, rb.velocity.y, movement.z * moveSpeed);

        // Check for jumping input and whether the player is grounded
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    // Implement your own grounded check function, e.g., using raycasting
    bool CheckGrounded()
    {
        // Replace this with your grounded check logic, e.g., raycasting or collision detection.
        return Physics.Raycast(transform.position, Vector3.down, 1.0f);
    }
}
