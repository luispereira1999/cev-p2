using UnityEngine;

public class OceanObjectsController : MonoBehaviour
{
    public Transform obstacle;
    public Transform trash;
    public int numberOfObstacles;
    public int numberOfTrash;

    private Camera mainCamera;
    private CameraFollowPlayer cameraFollowPlayerScript;
    private float limitMinX, limitMaxX;
    private float limitMinY, limitMaxY;

    void Start()
    {
        mainCamera = Camera.main;
        cameraFollowPlayerScript = mainCamera.GetComponent<CameraFollowPlayer>();

        limitMinX = cameraFollowPlayerScript.limitMinX;
        limitMaxX = cameraFollowPlayerScript.limitMaxX;
        limitMinY = cameraFollowPlayerScript.limitMinY;
        limitMaxY = cameraFollowPlayerScript.limitMaxY;

        for (int i = 0; i < numberOfObstacles; i++)
        {
            Vector3 position = new Vector3(Random.Range(limitMinX, limitMaxX), Random.Range(limitMinY, limitMaxY), 0);
            insertObstacle(position);
        }

        for (int i = 0; i < numberOfTrash; i++)
        {
            Vector3 position = new Vector3(Random.Range(limitMinX, limitMaxX), Random.Range(limitMinY, limitMaxY), 0);
            insertTrash(position);
        }
    }

    void insertObstacle(Vector3 position)
    {
        Instantiate(obstacle, position, Quaternion.identity);
    }

    void insertTrash(Vector3 position)
    {
        Instantiate(trash, position, Quaternion.identity);
    }
}
