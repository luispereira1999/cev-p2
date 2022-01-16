using UnityEngine;

public class ShipAnimation : MonoBehaviour
{
    public Animator playerAnimator;
    private BoxCollider2D boxCollider2d;

    void Start()
    {
        boxCollider2d = this.GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            playerAnimator.Play("front");
            boxCollider2d.offset = new Vector2(-0.004731469f, -0.001577131f);
            boxCollider2d.size = new Vector2(0.2497821f, 0.4677865f);
        }
        if (Input.GetAxisRaw("Vertical") < 0)
        {
            playerAnimator.Play("back");
            boxCollider2d.offset = new Vector2(-0.004731469f, -0.001577131f);
            boxCollider2d.size = new Vector2(0.2497821f, 0.4677865f);
        }
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            playerAnimator.Play("right");
            boxCollider2d.offset = new Vector2(-0.01311266f, 0.03933808f);
            boxCollider2d.size = new Vector2(0.6268872f, 0.397415f);
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            playerAnimator.Play("left");
            boxCollider2d.offset = new Vector2(-0.01311266f, 0.03933808f);
            boxCollider2d.size = new Vector2(0.6268872f, 0.397415f);
        }
    }
}
