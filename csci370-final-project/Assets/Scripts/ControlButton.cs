using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlButton : MonoBehaviour
{
    public void LoadControls() {
        SceneManager.LoadScene("Controls");
    }
}
