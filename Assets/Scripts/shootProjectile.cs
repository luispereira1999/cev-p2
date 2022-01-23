using UnityEngine;

public class ShootProjectile : MonoBehaviour
{
    public float speed;
    public float angle;

    void Start()
    {
        Vector3 direction = Quaternion.AngleAxis(angle, Vector3.forward) * Vector3.right;
        GetComponent<Rigidbody2D>().AddForce(direction * speed);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy") && gameObject.name == "ball(Clone)")
        {
            Enemy.health -= 0.15f;
            Destroy(gameObject);
        }
        else if (collision.CompareTag("Player") && gameObject.name == "projectile(Clone)")
        {
            HeroLevel3.health -= 0.15f;
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject, 2);
        }
    }
}
