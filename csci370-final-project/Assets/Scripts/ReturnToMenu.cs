using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour {
    public void LoadMenu() {
        Destroy(GameObject.Find("JournalCanvas"));
        SceneManager.LoadScene("Menu");
    }
}