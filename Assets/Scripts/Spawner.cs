using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject sferaPrefab;
    [SerializeField] private float respawnTime = 2f;

    private float _currentRespawnTime;
    private float _xPos;

    private void Update()
    {
        if (_currentRespawnTime > 0)
        {
            _currentRespawnTime -= Time.deltaTime;
        }
        else
        {
            SpawnSfere();
            _currentRespawnTime = respawnTime;
        }
    }

    private void SpawnSfere()
    {
        _xPos = Random.Range(-20f, 20f);
        GameObject a = Instantiate(sferaPrefab, new Vector3(_xPos, transform.position.y), transform.rotation);
    }
}
