using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public Transform obstacle;
    public Transform trash;
    public int numberOfObstacles;
    public int numberOfTrash;

    // é chamado antes do primeiro frame
    void Start()
    {
        for (int i = 0; i < numberOfObstacles; i++)
        {
            Vector3 position = new Vector3(Random.Range(9.4f, -9.4f), Random.Range(9.3f, -9.3f), 0);
            insertObstacle(position);
        }

        for (int i = 0; i < numberOfTrash; i++)
        {
            Vector3 position = new Vector3(Random.Range(9.4f, -9.4f), Random.Range(9.3f, -9.3f), 0);
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