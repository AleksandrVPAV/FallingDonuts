using UnityEngine;

public class SmallPinkBlock : SmallBlock
{
    [SerializeField] private float speedIncreasePerSecond;

    private float currentSpeed = 1f;

    private void Update()
    {
        currentSpeed += speedIncreasePerSecond * Time.deltaTime;

        GetComponent<Rigidbody2D>().velocity = Vector2.down * currentSpeed;
    }
}
