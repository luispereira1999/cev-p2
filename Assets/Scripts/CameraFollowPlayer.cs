using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    [SerializeField]
    private Transform targetToFollow;
    public float limitMinX;
    public float limitMaxX;
    public float limitMinY;
    public float limitMaxY;

    void Update()
    {
        transform.position = new Vector3(
            Mathf.Clamp(targetToFollow.position.x, limitMinX, limitMaxX),
            Mathf.Clamp(targetToFollow.position.y, limitMinY, limitMaxY),
            transform.position.z);
    }
}
