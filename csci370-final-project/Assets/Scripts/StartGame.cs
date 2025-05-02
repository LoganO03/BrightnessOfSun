using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void LoadEarth() {
        SceneManager.LoadScene("T1-Earth-Mason");
    }
}
