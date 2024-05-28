using UnityEngine;

public class SpinX : MonoBehaviour
{
    private const float SPEED = 1000.0f;
    void FixedUpdate()
    {
        transform.Rotate(Vector3.forward * SPEED * Time.deltaTime);
    }
}
