using UnityEngine;

public class PersistentJournal : MonoBehaviour {
    void Awake() {
        DontDestroyOnLoad(gameObject);
    }
}