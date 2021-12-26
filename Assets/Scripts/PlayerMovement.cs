using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    private float diretionX;
    private float diretionY;

    // é chamado antes do primeiro frame
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // é chamado a cada frame
    void Update()
    {
        diretionX = Input.GetAxisRaw("Horizontal") * speed;
        diretionY = Input.GetAxisRaw("Vertical") * speed;

        transform.position = new Vector2(
            Mathf.Clamp(transform.position.x, -9.4f, 9.4f),
            Mathf.Clamp(transform.position.y, -9.3f, 9.3f));
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(diretionX, diretionY);
    }
}
