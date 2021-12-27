using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int lives;

    // é chamado antes do primeiro frame
    void Start()
    {
        startPosition();
    }

    // ao colidir com os objetos do mapa
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

    void startPosition()
    {
        Vector3 startPosition = new Vector3(-9.4f, 9.3f, 0f);
        this.transform.position = startPosition;
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