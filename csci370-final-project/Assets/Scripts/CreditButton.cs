using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditButton : MonoBehaviour {
    public void LoadCredits() {
        SceneManager.LoadScene("Credits");
    }
}