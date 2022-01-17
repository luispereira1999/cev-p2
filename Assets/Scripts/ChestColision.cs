using UnityEngine;
using UnityEngine.UI;

public class ChestColision : MonoBehaviour
{
    public Animator playerAnimator;
    private AudioSource sound;

    //public int requiredPeaces;
    //private int foundPeaces;
    //public Text textPeaces;

    void Start()
    {
        //foundPeaces = 0;
        sound = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.IsTouching(collision.otherCollider))
        {
            GameObject item = collision.otherCollider.gameObject;
            GameObject peace = collision.collider.gameObject;

            if (item.tag != "Untaggdd")
            {
                playerAnimator.Play("open");
                sound.Play();
                //item.tag = "Untagged";
                Debug.Log("recolhido");
                //OpenChest();
            }
        }
    }

    void OpenChest()
    {
        playerAnimator.Play("open");
        sound.Play();
    }
}
