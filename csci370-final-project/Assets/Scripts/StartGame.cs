using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void LoadEarth() {
        audioSource.Play();
        SceneManager.LoadScene("T1-Earth-Mason");
    }
}