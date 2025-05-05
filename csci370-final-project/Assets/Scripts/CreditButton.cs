using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class CreditButton : MonoBehaviour {
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void LoadCredits() {
        audioSource.Play();
        SceneManager.LoadScene("Credits");
    }
}