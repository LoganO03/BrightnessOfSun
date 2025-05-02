using UnityEngine;

public class SubmitPlanets : MonoBehaviour {
    private bool MercuryInPlace;
    private bool EarthInPlace;
    private bool MarsInPlace;
    public GameObject VictoryScreen;
    public GameObject FailText;
    
    public void AssessPlanetOrder() {
        MercuryInPlace = GameObject.Find("PlanetBoxMercury").GetComponent<PlanetDrop>().inPlace;
        EarthInPlace = GameObject.Find("PlanetBoxEarth").GetComponent<PlanetDrop>().inPlace;
        MarsInPlace = GameObject.Find("PlanetBoxMars").GetComponent<PlanetDrop>().inPlace;
        if (MercuryInPlace && EarthInPlace && MarsInPlace) {
            VictoryScreen.SetActive(true);
            FailText.SetActive(false);
        } else {
            FailText.SetActive(true);
        }
    }
}