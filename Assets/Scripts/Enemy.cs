using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;

    public AudioSource attackSound;

    public Transform projectile;
    public Transform projectilePivot;
    public GameObject player;
    public static float health;

    void Start()
    {
        InvokeRepeating("Attack", 2f, 0.8f);
        health = 3;
    }

    void Update()
    {
        if (player != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
    }

    private void Attack()
    {
        if (Vector2.Distance(transform.position, player.transform.position) < 8)
        {
            attackSound.Play();

            Vector3 dir = player.transform.position - transform.position;
            dir = player.transform.InverseTransformDirection(dir);
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

            Instantiate(projectile, projectilePivot.position, transform.rotation);
            projectile.GetComponent<ShootProjectile>().speed = 500f;
            projectile.GetComponent<ShootProjectile>().angle = angle;
        }
    }
}
