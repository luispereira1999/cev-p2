using UnityEngine;

public class ShootProjectile : MonoBehaviour
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
            //Destroy(gameObject);
        }
        else if (collision.CompareTag("Player"))
        {
            //Destroy(gameObject);
        }
        else
        {
            //Destroy(gameObject, 2);
        }
    }
}
