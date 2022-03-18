using TMPro;
using UnityEngine;

public class GameParameters : MonoBehaviour {
    [SerializeField] private TMP_InputField spawnDelayInput;
    [SerializeField] private TMP_InputField cubeSpeedInput;
    [SerializeField] private TMP_InputField travelDistanceInput;

    private float spawnDelay;
    private float cubeSpeed;
    private float travelDistance;

    private void Awake() {
        spawnDelay = float.Parse(spawnDelayInput.text);
        cubeSpeed = float.Parse(cubeSpeedInput.text);
        travelDistance = float.Parse(travelDistanceInput.text);
    }

    public float GetSpawnDelay() {
        return spawnDelay;
    }

    public float GetCubeSpeed() {
        return cubeSpeed;
    }

    public float GetTravelDistance() {
        return travelDistance;
    }

    public void SetSpawnDelay(string _spawnDelay) {
        spawnDelay = float.Parse(_spawnDelay);
    }

    public void SetCubeSpeed(string _cubeSpeed) {
        cubeSpeed = float.Parse(_cubeSpeed);
    }

    public void SetTravelDistance(string _travelDistance) {
        travelDistance = float.Parse(_travelDistance);
    }
}