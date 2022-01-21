using UnityEngine;

public class HealthBar : MonoBehaviour
{
    private Vector2 localScale;

    void Start()
    {
        localScale = transform.localScale;
    }

    void Update()
    {
        localScale.x = HeroLevel3.health;
        transform.localScale = localScale;
    }
}
