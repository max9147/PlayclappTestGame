using System.Collections;
using UnityEngine;

public class CubeSpawner : MonoBehaviour {
    [SerializeField] private GameObject cubeSpawnPoint;
    [SerializeField] private GameObject cubePrefab;

    private GameParameters gameParameters;

    private void Start() {
        gameParameters = GetComponent<GameParameters>();
        StartCoroutine(SpawnCube());
    }

    private IEnumerator SpawnCube() {
        Instantiate(cubePrefab, cubeSpawnPoint.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(gameParameters.GetSpawnDelay());
        StartCoroutine(SpawnCube());
    }
}