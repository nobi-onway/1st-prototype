using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private const float SPEED = 20.0f;
    private const float ROTATION_SPEED = 45.0f;

    void FixedUpdate()
    {
        MoveForward();
        ChangeDirection();
    }

    private void MoveForward()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * SPEED * horizontalInput * Time.deltaTime);
    }

    private void ChangeDirection()
    {
        float verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.left * ROTATION_SPEED * verticalInput * Time.deltaTime);
    }
}
