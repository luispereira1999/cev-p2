using UnityEngine;

public class EnemyHealthBar : MonoBehaviour
{
    private Vector2 localScale;

    void Start()
    {
        localScale = transform.localScale;
    }

    void Update()
    {
        localScale.x = Enemy.health;
        transform.localScale = localScale;
    }
}
