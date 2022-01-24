using UnityEngine;

public class Ship : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    private Vector3 movement;
    private bool isMoving = false;

    public AudioSource movementSound;
    public Animator playerAnimator;
    private BoxCollider2D boxCollider2d;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        boxCollider2d = this.GetComponent<BoxCollider2D>();
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
            if (!movementSound.isPlaying)
            {
                movementSound.Play();
            }
        }
        else
        {
            movementSound.Stop();
        }
    }

    private void MovePlayer()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        transform.position += movement * Time.deltaTime * speed;
    }

    private void PressKeys()
    {
        if (Input.GetAxisRaw("Vertical") == 1)
        {
            playerAnimator.Play("front");
            boxCollider2d.offset = new Vector2(-0.004731469f, -0.001577131f);
            boxCollider2d.size = new Vector2(0.2497821f, 0.4677865f);
        }
        if (Input.GetAxisRaw("Vertical") == -1)
        {
            playerAnimator.Play("back");
            boxCollider2d.offset = new Vector2(-0.004731469f, -0.001577131f);
            boxCollider2d.size = new Vector2(0.2497821f, 0.4677865f);
        }
        if (Input.GetAxisRaw("Horizontal") == 1)
        {
            playerAnimator.Play("right");
            boxCollider2d.offset = new Vector2(-0.01311266f, 0.03933808f);
            boxCollider2d.size = new Vector2(0.6268872f, 0.397415f);
        }
        if (Input.GetAxisRaw("Horizontal") == -1)
        {
            playerAnimator.Play("left");
            boxCollider2d.offset = new Vector2(-0.01311266f, 0.03933808f);
            boxCollider2d.size = new Vector2(0.6268872f, 0.397415f);
        }
    }

    void FixedUpdate()
    {
        rb.velocity = movement;
    }
}
