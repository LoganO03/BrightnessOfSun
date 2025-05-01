using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToPlanet : MonoBehaviour, IInteractable
{
    public void Interact() {
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "T1-Earth-Mason") {
            SceneManager.LoadScene("T2-Mars-Mason");
        } else if (currentScene.name == "T2-Mars-Mason") {
            SceneManager.LoadScene("T3-Mercury-Mason");
        } else if (currentScene.name == "T3-Mercury-Mason") {
            SceneManager.LoadScene("PlanetSelection");
        }
    }
}
