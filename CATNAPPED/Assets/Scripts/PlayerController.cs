using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Get input from the player
        moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        // Normalize input to prevent diagonal movement from being faster
        if (moveInput.magnitude > 0)
        {
            moveInput.Normalize();
            // Move the player
            Vector2 movement = moveInput * movementSpeed * Time.deltaTime;
            transform.Translate(movement, Space.World);
        }

        // Update Animator Parameters based on movement
        HandleAnimations();
    }

    private void HandleAnimations()
    {
        if (moveInput.magnitude > 0)
        {
            // Set "isWalking" to true if the player is moving
            animator.SetBool("isWalking", true);

            // Set direction-based parameters for animation
            animator.SetFloat("X", moveInput.x);  // Horizontal movement
            animator.SetFloat("Y", moveInput.y);  // Vertical movement
        }
        else
        {
            // Set "isWalking" to false when the player is idle
            animator.SetBool("isWalking", false);

            // Optional: Set the last input to keep the character facing the last direction
            animator.SetFloat("LastInputX", moveInput.x);
            animator.SetFloat("LastInputY", moveInput.y);
        }
    }
}
