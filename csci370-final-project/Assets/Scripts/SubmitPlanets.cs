using UnityEngine;

public class SubmitPlanets : MonoBehaviour
{
    private bool mercuryInPlace;
    private bool earthInPlace;
    private bool marsInPlace;
    public GameObject victoryScreen;
    public GameObject failText;
    
    public void AssessPlanetOrder() {
        mercuryInPlace = GameObject.Find("PlanetBoxMercury").GetComponent<PlanetDrop>().inPlace;
        earthInPlace = GameObject.Find("PlanetBoxEarth").GetComponent<PlanetDrop>().inPlace;
        marsInPlace = GameObject.Find("PlanetBoxMars").GetComponent<PlanetDrop>().inPlace;
        if (mercuryInPlace && earthInPlace && marsInPlace) {
            victoryScreen.SetActive(true);
            failText.SetActive(false);
        } else {
            failText.SetActive(true);
        }
    }

}
