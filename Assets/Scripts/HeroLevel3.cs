using UnityEngine;

public class HeroLevel3 : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    private Vector3 movement;
    private bool isMoving = false;
    private AudioSource sound;

    public Animator playerAnimator;

    public Transform projectile;
    private float angle;
    public Transform projectilePivot;

    public static float health;

    public GameObject panelWin;
    public GameObject panelLose;
    public GameObject enemy;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sound = GetComponent<AudioSource>();
        angle = 0f;
        health = 1;
    }

    void Update()
    {
        MovePlayer();
        PressKeys();

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

        if (GameOver())
        {
            Destroy(Camera.main.GetComponent<CameraFollowPlayer>());
            Camera.main.transform.parent = null;

            Destroy(gameObject);
            panelLose.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        if (GameWin())
        {
            Destroy(enemy.gameObject);
            panelWin.gameObject.SetActive(true);
            Time.timeScale = 0;
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

    private void PressKeys()
    {
        if (Input.GetAxisRaw("Vertical") == 1)
        {
            playerAnimator.Play("hero-back");
            angle = 90f;
        }
        if (Input.GetAxisRaw("Vertical") == -1)
        {
            playerAnimator.Play("hero-front");
            angle = 270f;
        }
        if (Input.GetAxisRaw("Horizontal") == 1)
        {
            playerAnimator.Play("hero-right");
            angle = 0f;
        }
        if (Input.GetAxisRaw("Horizontal") == -1)
        {
            playerAnimator.Play("hero-left");
            angle = 180f;
        }
        if (Input.GetKeyDown("space"))
        {
            Attack();
        }
    }

    public void Attack()
    {
        Instantiate(projectile, projectilePivot.position, transform.rotation);
        projectile.GetComponent<ShootProjectile>().speed = 500f;
        projectile.GetComponent<ShootProjectile>().angle = angle;
    }

    bool GameOver()
    {
        if (health <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    bool GameWin()
    {
        if (Enemy.health <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
