using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    private const float TURN_SPEED = 45.0f;
    [SerializeField]
    private TextMeshProUGUI _speedometer;

    [SerializeField]
    private float _horsePower;

    private Rigidbody _rb;
    [SerializeField]
    private List<WheelCollider> _wheelColliders;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if(IsOnGround())
        {
            MoveForward();
        }
        ChangeDirection();
    }

    private void MoveForward()
    {
        float verticalInput = Input.GetAxis("Vertical");

        _rb.AddRelativeForce(Vector3.forward * _horsePower * verticalInput);

        int speedKilometerPerHour = Mathf.RoundToInt(_rb.velocity.magnitude);
        _speedometer.SetText($"Speed: {speedKilometerPerHour} Km/h");
    }

    private void ChangeDirection()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up * TURN_SPEED * horizontalInput * Time.deltaTime);
    }

    private bool IsOnGround()
    {
        int numsOfGroundedWheel = 0;
        foreach(WheelCollider wheelCollider in _wheelColliders)
        {
            if (!wheelCollider.isGrounded) continue;
            numsOfGroundedWheel++;
        }

        return numsOfGroundedWheel == 4;
    }
}
