using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private const float SPEED = 20.0f;
    void Update()
    {
        transform.Translate(Vector3.forward * SPEED * Time.deltaTime);
    }
}
