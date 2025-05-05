using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void LoadMenu() {
        audioSource.Play();
        SceneManager.LoadScene("Menu");
    }
}
