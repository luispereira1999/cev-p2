using UnityEngine;

public class ChestColision : MonoBehaviour
{
    public Animator playerAnimator;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.IsTouching(collision.otherCollider))
        {
            GameObject item = collision.collider.gameObject;

            if (item.tag == "Hero")
            {
                OpenChest();
            }
        }
    }

    void OpenChest()
    {
        playerAnimator.Play("open");
    }
}
