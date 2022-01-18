using UnityEngine;
using UnityEngine.UI;

public class ChestColision : MonoBehaviour
{
    public Animator playerAnimator;
    private AudioSource sound;

    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.IsTouching(collision.otherCollider))
        {
            GameObject item = collision.otherCollider.gameObject;
         
            if (item.tag == "Peace")
            {
                OpenChest();
            }
        }
    }

    private void OpenChest()
    {
        playerAnimator.Play("open");
        sound.Play();
    }
}
