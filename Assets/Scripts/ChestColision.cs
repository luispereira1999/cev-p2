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
            GameObject chest = collision.otherCollider.gameObject;
           
            if (chest.tag != "Untagged")
            {
                OpenChest();
                chest.tag = "Untagged";
            }
        }
    }

    private void OpenChest()
    {
        playerAnimator.Play("open");
        sound.Play();
    }
}
