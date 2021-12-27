using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform targetToFollow;

    void Update()
    {
        transform.position = new Vector3(
            Mathf.Clamp(targetToFollow.position.x,
            -4.5f, 4.5f), Mathf.Clamp(targetToFollow.position.y,
            -5.1f, 5.1f), transform.position.z);
    }
}