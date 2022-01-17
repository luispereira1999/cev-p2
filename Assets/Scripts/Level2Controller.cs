using UnityEngine;
using UnityEngine.UI;

public class Level2Controller : MonoBehaviour
{
    public int requiredPeaces;
    private int foundPeaces;
    public Text text;

    void Start()
    {
        foundPeaces = 0;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.IsTouching(collision.otherCollider))
        {
            GameObject item = collision.collider.gameObject;

            if (item.tag != "Untagged")
            {
                collectPeace();
                //item.tag = "Untagged";
            }
        }
    }

    void collectPeace()
    {
        this.foundPeaces++;
        text.text = this.foundPeaces.ToString();
    }

    bool gameWin()
    {
        if (this.foundPeaces == requiredPeaces)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
