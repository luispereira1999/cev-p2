using UnityEngine;

public class HeroAnimation : MonoBehaviour
{
    public Animator playerAnimator;

    void Update()
    {
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            playerAnimator.Play("front");
        }
        if (Input.GetAxisRaw("Vertical") < 0)
        {
            playerAnimator.Play("back");
        }
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            playerAnimator.Play("right");
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            playerAnimator.Play("left");
        }
    }
}
