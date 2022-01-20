using UnityEngine;

public class HeroLevel3 : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    private Vector3 movement;
    private bool isMoving = false;
    private AudioSource sound;

    public Transform projectile;
    public Transform projectilePivot;
    public GameObject enemy;
    private Vector3 positionVector;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sound = GetComponent<AudioSource>();
    }

    void Update()
    {
        MovePlayer();

        if (rb.velocity.x != 0 || rb.velocity.y != 0)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

        if (isMoving)
        {
            if (!sound.isPlaying)
            {
                sound.Play();
            }
        }
        else
        {
            sound.Stop();
        }

        if (Input.GetAxisRaw("Vertical") > 0)
        {
            positionVector = Vector2.up;
        }
        if (Input.GetAxisRaw("Vertical") < 0)
        {
            positionVector = Vector2.down;
        }
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            positionVector = Vector2.right;
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            positionVector = Vector2.left;
        }

        if (Input.GetKeyDown("space"))
        {
            shootProjectile();
        }
    }

    private void MovePlayer()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        transform.position += movement * Time.deltaTime * speed;
    }

    void FixedUpdate()
    {
        rb.velocity = movement;
    }

    public void shootProjectile()
    {
        Instantiate(projectile, projectilePivot.position, Quaternion.identity);
        projectile.GetComponent<shootProjectile>().positionVector = positionVector;
    }
}
