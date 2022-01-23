using UnityEngine;

public class HeroHealthBar : MonoBehaviour
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
