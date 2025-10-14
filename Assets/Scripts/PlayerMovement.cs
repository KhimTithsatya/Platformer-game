

using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 7f;
    private Rigidbody2D rb;

    private void Awake()
    {
        // Get the Rigidbody2D component
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Get horizontal movement input (A/D or Arrow keys)
        float direction = Input.GetAxis("Horizontal");

        // Move the player horizontally
        rb.linearVelocity = new Vector2(direction * speed, rb.linearVelocity.y);

        // Jump when Space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }
}
