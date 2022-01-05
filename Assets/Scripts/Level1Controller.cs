using UnityEngine;

public class Level1Controller : MonoBehaviour
{
    public int lives;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.IsTouching(collision.otherCollider))
        {
            GameObject item = collision.collider.gameObject;

            if (item.tag == "Trash")
            {
                Debug.Log("Recolheu lixo");
                Destroy(collision.collider.gameObject);
            }
            else if (item.tag == "Obstacle")
            {
                Debug.Log("Perdeu uma vida");
                loseLive();

                if (this.gameOver())
                {
                    Debug.Log("Game Over!");
                }
            }
        }
    }

    void loseLive()
    {
        this.lives--;
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
