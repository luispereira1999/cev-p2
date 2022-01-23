using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Transform target;

    public Transform projectile;
    public Transform projectilePivot;
    public GameObject player;
    public static float health;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        InvokeRepeating("Attack", 2f, 0.8f);
        health = 3;
    }

    void Update()
    {
        if (target != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }

    private void Attack()
    {
        Vector3 dir = player.transform.position - transform.position;
        dir = player.transform.InverseTransformDirection(dir);
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

        Instantiate(projectile, projectilePivot.position, transform.rotation);
        projectile.GetComponent<ShootProjectile>().speed = 500f;
        projectile.GetComponent<ShootProjectile>().angle = angle;
    }
}
