using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 5f;
    public float turnSpeed = 100f;
    public float jumpForce = 5f;
    public KeyCode jumpKey = KeyCode.Space;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
        Turn();
        Jump();
    }

    private void Move()
    {
        float moveDirection = Input.GetAxis("Vertical");
        Vector3 movement = transform.forward * moveDirection * moveSpeed * Time.deltaTime;
        transform.position += movement;
    }

    private void Turn()
    {
        float turnDirection = Input.GetAxis("Horizontal");
        Vector3 rotation = Vector3.up * turnDirection * turnSpeed * Time.deltaTime;
        transform.Rotate(rotation);
    }

    private void Jump()
    {
        if (Input.GetKeyDown(jumpKey) && IsGrounded())
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private bool IsGrounded()
    {

        return Physics.Raycast(transform.position, Vector3.down, 1.1f);
    }
}