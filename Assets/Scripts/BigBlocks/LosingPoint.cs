using UnityEngine;
using UnityEngine.UI;

public class LosingPoint : MonoBehaviour
{
   
    [SerializeField] private GameObject[] _lifeSprites;
    [SerializeField] private int _numberOfLives;

    private int _maxCountOfLife = 2;
    private void Update()
    {
        for (int i = 0; i < _lifeSprites.Length; i++)
        {
            if (i < _numberOfLives)
            {
                _lifeSprites[i].SetActive(true);
            }
            else
            {
                _lifeSprites[i].SetActive(false);
            }
        }

        if (_numberOfLives > _maxCountOfLife)
        {
            _numberOfLives = _maxCountOfLife;
        }
    }


private void OnTriggerEnter2D(Collider2D collision)
    {
        SmallBlueBlock smallBlueBlock = collision.GetComponent<SmallBlueBlock>();
        SmallPinkBlock smallPinkBlock = collision.GetComponent<SmallPinkBlock>();
        if (smallBlueBlock != null || smallPinkBlock != null)
        {
            _numberOfLives--;
            if (_numberOfLives <= 0)
            {
                Debug.Log("Game Over");
            }
        }
    }
}
