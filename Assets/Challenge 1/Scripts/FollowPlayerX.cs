using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 _offsetPos = new Vector3(20, 0 ,0);

    void LateUpdate()
    {
        transform.position = plane.transform.position + _offsetPos;
    }
}
