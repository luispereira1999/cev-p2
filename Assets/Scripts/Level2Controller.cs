using UnityEngine;
using UnityEngine.UI;

public class Level2Controller : MonoBehaviour
{
    public int requiredPeaces;
    private int foundPeaces;
    public Text textPeaces;

    public AudioSource loseSound;
    public AudioSource winSound;

    public GameObject panelWin;
    public GameObject panelLose;

    void Start()
    {
        foundPeaces = 0;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.IsTouching(collision.otherCollider))
        {
            GameObject item = collision.collider.gameObject;

            if (item.tag == "Peace")
            {
                collectPeace();
                item.tag = "Untagged";

                if (this.gameWin())
                {
                    winSound.Play();
                    panelWin.gameObject.SetActive(true);
                }
            }
        }
    }

    void collectPeace()
    {
        this.foundPeaces++;
        textPeaces.text = this.foundPeaces.ToString();
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
