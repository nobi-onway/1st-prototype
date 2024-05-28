using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerTransform;
    private Vector3 _offsetPos = new Vector3(0, 4.5f, -6.5f);

    private void LateUpdate()
    {
        transform.position = playerTransform.position + _offsetPos;
    }
}
