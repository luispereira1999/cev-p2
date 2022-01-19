using UnityEngine;
using UnityEngine.UI;

public class MoveObjectAutomatically : MonoBehaviour
{
    public Image windmill1;
    //private GameObject meteor;
    public GameObject missil;
    public GameObject meteor;
    private float speed = 2f;
    private Camera mainCamera;

    void Start()
    {
        //windmill1 = GameObject.Find("Image-windmill-1");
        //meteor = GameObject.Find("Image-windmill-2");
        //windmill3 = GameObject.Find("Image-windmill-3");
        //windmill3 = GameObject.Find("windmill-parts_0");
        //missil.rectTransform.anchoredPosition = new Vector2(586f,0f);

        mainCamera = Camera.main;
    }

    void Update()
    {
        Vector2 endPosition = new Vector2(0f, 0f);
        //float speed = 5f * Time.deltaTime;

        //windmill1.transform.position = Vector3.MoveTowards(startPosition, endPosition, speed);

        //GetComponent<Transform>().localPosition = Vector3.MoveTowards(startPosition, endPosition, speed);
        //windmill3.transform.position = Vector2.MoveTowards(startPosition, endPosition, speed);
        //     GetComponent<Transform>().localPosition = startPosition;
        //missil.transform.position = Vector2.MoveTowards(missil.transform.position, meteor.transform.position, speed * Time.deltaTime);
        missil.transform.position = Vector2.MoveTowards(missil.transform.position, endPosition, speed * Time.deltaTime);
        //missil.transform.up = meteor.transform.position - missil.transform.position;
    }
}
