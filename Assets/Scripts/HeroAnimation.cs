using UnityEngine;

public class HeroAnimation : MonoBehaviour
{
    public Animator playerAnimator;

    void PlayAnimation()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            playerAnimator.Play("back");
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            playerAnimator.Play("front");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerAnimator.Play("right");
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerAnimator.Play("left");
        }
    }
}