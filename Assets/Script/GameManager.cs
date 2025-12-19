using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;

    void Start()
    {
        CreateEnemy();
    }

    private void CreateEnemy()
    {
        Vector3 enemyPos = new Vector3(0, 5.5f, 0);
        Instantiate(_enemyPrefab, enemyPos, Quaternion.identity);
    }
}