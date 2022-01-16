using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float playerSpeed;
    private float diretionX;
    private float diretionY;
    //public float limitMinX;
    //public float limitMaxX;
    //public float limitMinY;
    //public float limitMaxY;

    private AudioSource sound;
    private bool isMoving = false;
    public GameObject projectile;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sound = GetComponent<AudioSource>();
    }

    void Update()
    {
        diretionX = Input.GetAxis("Horizontal") * playerSpeed;
        diretionY = Input.GetAxis("Vertical") * playerSpeed;
        //diretionX = Input.GetAxisRaw("Horizontal") * playerSpeed;
        //diretionY = Input.GetAxisRaw("Vertical") * playerSpeed;

        //transform.position = new Vector2(
        //    Mathf.Clamp(transform.position.x, limitMinX, limitMaxX),
        //    Mathf.Clamp(transform.position.y, limitMinY, limitMaxY));

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

        if (Input.GetKeyDown("space"))
        {
            shootProjectile();
        }
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(diretionX, diretionY);
    }

    public void shootProjectile()
    {
        //GameObject p = Instantiate(projectile) as GameObject;
        //p.transform.position = transform.position;
    }
}
