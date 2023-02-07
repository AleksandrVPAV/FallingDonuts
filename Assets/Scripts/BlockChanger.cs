using UnityEngine;

public class BlockChanger : MonoBehaviour
{

    [SerializeField] private BigBlueBlock _blueBlock;
    [SerializeField] private BigPinkBlock _pinkBlock;
    private BigBlock currentObject;


    private void Start()
    {
        currentObject = _blueBlock;
        int numberActiveBlock = Random.Range(0,2);

        if (numberActiveBlock == 0)
        {
            _blueBlock.gameObject.SetActive(true);
            _pinkBlock.gameObject.SetActive(false);
        }
        else
        {
            _pinkBlock.gameObject.SetActive(true);
            _blueBlock.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (currentObject == _blueBlock)
            {
                _blueBlock.gameObject.SetActive(false);
                _pinkBlock.gameObject.SetActive(true);
                currentObject = _pinkBlock;
            }
            else if (currentObject == _pinkBlock)
            {
                _pinkBlock.gameObject.SetActive(false);
                _blueBlock.gameObject.SetActive(true);
                currentObject = _blueBlock;
            }
        }
    }
}

