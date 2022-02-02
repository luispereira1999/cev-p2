using UnityEngine;
using UnityEngine.UI;

public class Level1Controller : MonoBehaviour
{
    public int requiredTrash;
    private int foundTrash;
    public int lives;
    public Text textTrash;
    public Text textLives;

    public AudioSource loseSound;
    public AudioSource winSound;

    public GameObject panelWin;
    public GameObject panelLose;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.IsTouching(collision.otherCollider))
        {
            GameObject item = collision.collider.gameObject;

            if (item.tag == "Trash")
            {
                collectTrash();
                Destroy(collision.collider.gameObject);

                if (this.gameWin())
                {
                    winSound.Play();
                    Camera.main.gameObject.GetComponent<AudioSource>().volume = 0;
                    panelWin.gameObject.SetActive(true);
                    Time.timeScale = 0;
                }
            }
            else if (item.tag == "Obstacle")
            {
                collideWithObject();

                if (this.gameOver())
                {
                    loseSound.Play();
                    Camera.main.gameObject.GetComponent<AudioSource>().volume = 0;
                    panelLose.gameObject.SetActive(true);
                    Time.timeScale = 0;
                }
            }
        }
    }

    void collectTrash()
    {
        this.foundTrash++;
        textTrash.text = this.foundTrash.ToString();
    }

    void collideWithObject()
    {
        this.lives--;
        textLives.text = this.lives.ToString();
    }

    bool gameWin()
    {
        if (this.foundTrash == requiredTrash)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    bool gameOver()
    {
        if (this.lives == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
