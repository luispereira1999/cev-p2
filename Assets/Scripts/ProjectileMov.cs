using UnityEngine;

public class ProjectileMov : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;

    public GameObject explosion;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0f));
    }

    void Update()
    {
        Debug.Log("I m here");
        if (transform.position.x > screenBounds.x * -2)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "asteroid")
        {
            GameObject e = Instantiate(explosion) as GameObject;
            e.transform.position = transform.position;
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
