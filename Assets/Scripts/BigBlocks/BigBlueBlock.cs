using UnityEngine;
using UnityEngine.Events;

public class BigBlueBlock : BigBlock
{
    public event UnityAction smallBlueBlockBroken;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out SmallBlueBlock smallBlueBlock))
        {
            smallBlueBlockBroken?.Invoke();
            Destroy(smallBlueBlock.gameObject);
        }
    }
}
