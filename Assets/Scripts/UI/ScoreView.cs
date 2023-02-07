using UnityEngine;
using TMPro;

public class ScoreView : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreView;
    [SerializeField] private BigBlueBlock _bigBlueBlock;
    [SerializeField] private BigPinkBlock _bigPinkBlock;

    private int _score;

    private void Start()
    {
        _score = 0;
    }
    private void OnEnable()
    {
        _bigBlueBlock.smallBlueBlockBroken += OnsmallBlueBlockBroken;
        _bigPinkBlock.smallPinkBlockBroken += OnsmallPinkBlockBroken;
    }

    private void OnDisable()
    {
        _bigBlueBlock.smallBlueBlockBroken -= OnsmallBlueBlockBroken;
        _bigPinkBlock.smallPinkBlockBroken -= OnsmallPinkBlockBroken;
    }

    private void OnsmallBlueBlockBroken()
    {
        _score++;
        _scoreView.text = _score.ToString();
    }

    private void OnsmallPinkBlockBroken()
    {
        _score++;
        _scoreView.text = _score.ToString();
    }
}
