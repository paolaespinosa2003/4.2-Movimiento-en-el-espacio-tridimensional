
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    public float forwardSpeed = 5f;        // velocidad de avance en Z
    public float horizontalSpeed = 6f;     // velocidad lateral en X
    public float jumpForce = 6f;           // fuerza de salto
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotation;
    }

    void Update()
    {
        // Movimiento lateral por teclado (o joystick)
        float moveX = Input.GetAxis("Horizontal") * horizontalSpeed;

        // Mantener avance constante en Z (forward)
        Vector3 targetVel = new Vector3(moveX, rb.velocity.y, forwardSpeed);

        rb.velocity = new Vector3(targetVel.x, rb.velocity.y, targetVel.z);

        // Salto si está en el suelo (simple check usando raycast)
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, 1.1f);
    }
}
