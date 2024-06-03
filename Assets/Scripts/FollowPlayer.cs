using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerTransform;
    [SerializeField]
    private Vector3 _offsetPos;

    private void LateUpdate()
    {
        transform.position = playerTransform.position + _offsetPos;
    }
}
