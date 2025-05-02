using UnityEngine;

public class Rotate : MonoBehaviour {
    public Vector3 Rotation;

    void Update() {
        transform.Rotate(Rotation * 1 * Time.deltaTime);
    }
}