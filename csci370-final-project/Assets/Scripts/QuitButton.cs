using UnityEngine;

public class QuitButton : MonoBehaviour
{
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Bye bye!");
    }
}
