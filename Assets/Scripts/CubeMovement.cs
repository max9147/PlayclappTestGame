using UnityEngine;

public class CubeMovement : MonoBehaviour {
    [SerializeField] private Material[] cubeMaterials;

    private float cubeSpeed;
    private float travelDistance;
    private Vector3 startPos;
    private GameParameters gameParameters;

    private void Awake() {
        gameParameters = GameObject.Find("GameSystems").GetComponent<GameParameters>();
        cubeSpeed = gameParameters.GetCubeSpeed();
        travelDistance = gameParameters.GetTravelDistance();
        GetComponent<Renderer>().material = cubeMaterials[Random.Range(0, cubeMaterials.Length)];
    }

    private void Start() {
        startPos = transform.position;
    }

    private void FixedUpdate() {
        GetComponent<Rigidbody>().velocity = Vector3.forward * cubeSpeed;
        if((transform.position - startPos).magnitude > travelDistance) {
            Destroy(gameObject);
        }
    }
}