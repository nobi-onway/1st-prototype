using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private const float SPEED = 20.0f;
    private const float TURN_SPEED = 45.0f;
    void FixedUpdate()
    {
        MoveForward();
        ChangeDirection();
    }

    private void MoveForward()
    {
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * SPEED * verticalInput * Time.deltaTime);
    }

    private void ChangeDirection()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up * TURN_SPEED * horizontalInput * Time.deltaTime);
    }
}
