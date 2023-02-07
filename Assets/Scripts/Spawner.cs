using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private SmallBlock[] _smalBlocks;
    [SerializeField] private SmallBlockSpawnPoint[] _smalBlocksSpawnPoint;
    [SerializeField] private float _spawnInterval;  // recomended 1.3
    [SerializeField] private float _spawnSpeedUp;   // recomended 5

    private float timeSinceLastSpawn = 0f;
    private int _lastSpawnPoint = -1;
    private float minTimeofSpawn = 0.25f;

    private void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= _spawnInterval)
        {
            timeSinceLastSpawn = 0f;
            int blockNumber = Random.Range(0, _smalBlocks.Length);
            int spawnPointNumber = Random.Range(0, _smalBlocksSpawnPoint.Length);
            while (spawnPointNumber == _lastSpawnPoint)
            {
                spawnPointNumber = Random.Range(0, _smalBlocksSpawnPoint.Length);
            }
            _lastSpawnPoint = spawnPointNumber;

            SmallBlock block = Instantiate(_smalBlocks[blockNumber], _smalBlocksSpawnPoint[spawnPointNumber].transform.position, Quaternion.identity);
            _spawnInterval -= _spawnSpeedUp * Time.deltaTime;
            if (_spawnInterval <= minTimeofSpawn)
            {
                _spawnInterval = minTimeofSpawn;
            }
            if (_spawnInterval <= 0.6)
            {
                _spawnSpeedUp = 0.5f;
            }
            if (_spawnInterval <= 0.35)
            {
                _spawnSpeedUp = 0.2f;
            }
        }
    }
}
