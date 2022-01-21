using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float stopMoving;
    private Transform target;

    public Transform projectile;
    public Transform projectilePivot;
    public GameObject player;
    private Vector2 positionVector;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        InvokeRepeating("Attack", 4f, 1f);
        positionVector = Vector2.up;
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) > stopMoving)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }

    private void Attack()
    {
        Vector2 playerPosition = player.transform.position;

        if (playerPosition.x >= transform.position.x && (playerPosition.y <= transform.position.y + 2 || playerPosition.y <= transform.position.y - 2))  // direita
        {
            positionVector = Vector2.right;
        }
        else if (playerPosition.x <= transform.position.x && (playerPosition.y <= transform.position.y + 2 || playerPosition.y <= transform.position.y - 2))  // esquerda
        {
            positionVector = Vector2.left;
        }
        else if (playerPosition.y >= transform.position.y)  // acima
        {
            positionVector = Vector2.up;
        }
        else if (playerPosition.y <= transform.position.y)  // abaixo
        {
            positionVector = Vector2.down;
        }

        Instantiate(projectile, projectilePivot.position, Quaternion.identity);
        projectile.GetComponent<ShootProjectile>().positionVector = positionVector;
    }
}
