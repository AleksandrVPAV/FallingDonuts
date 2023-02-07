using UnityEngine;
using UnityEngine.Events;

public class BigPinkBlock : BigBlock
{
    public event UnityAction smallPinkBlockBroken;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out SmallPinkBlock smallPinkBlock))
        {
            smallPinkBlockBroken?.Invoke();
            Destroy(smallPinkBlock.gameObject);
        }
    }
}
