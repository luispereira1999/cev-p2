using UnityEngine;

public class Ship : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    private Vector3 movement;
    private bool isMoving = false;
    private AudioSource sound;

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
}
