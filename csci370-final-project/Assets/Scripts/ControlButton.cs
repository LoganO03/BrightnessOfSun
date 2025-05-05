using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlButton : MonoBehaviour{
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void LoadControls() {
        audioSource.Play();
        SceneManager.LoadScene("Controls");
    }
}
