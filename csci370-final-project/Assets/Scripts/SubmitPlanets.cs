using UnityEngine;

public class SubmitPlanets : MonoBehaviour
{
    private bool mercuryInPlace;
    private bool earthInPlace;
    private bool marsInPlace;
    
    public void AssessPlanetOrder() {
        mercuryInPlace = GameObject.Find("PlanetBoxMercury").GetComponent<PlanetDrop>().inPlace;
        earthInPlace = GameObject.Find("PlanetBoxEarth").GetComponent<PlanetDrop>().inPlace;
        marsInPlace = GameObject.Find("PlanetBoxMars").GetComponent<PlanetDrop>().inPlace;
        if (mercuryInPlace && earthInPlace && marsInPlace) {
            Debug.Log("Success!");
        } else {
            Debug.Log("Failure!");
        }
    }

}
