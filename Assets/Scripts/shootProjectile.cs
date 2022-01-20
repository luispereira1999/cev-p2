using UnityEngine;

public class shootProjectile : MonoBehaviour
{
    public Vector2 positionVector;

    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(positionVector * 700);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Debug.Log("ATACOU INIMIGO");
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject, 2);
        }
    }
}
