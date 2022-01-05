using UnityEngine;

public class StartPosition : MonoBehaviour
{
    public float positionX;
    public float positionY;

    void Start()
    {
        Vector3 startPosition = new Vector3(positionX, positionY, 0f);
        this.transform.position = startPosition;
    }
}
