using UnityEngine;

public class SubmitPlanets : MonoBehaviour
{
    private bool mercuryInPlace;
    private bool earthInPlace;
    private bool saturnInPlace;
    
    public void AssessPlanetOrder() {
        mercuryInPlace = GameObject.Find("PlanetBoxMercury").GetComponent<PlanetDrop>().inPlace;
        earthInPlace = GameObject.Find("PlanetBoxEarth").GetComponent<PlanetDrop>().inPlace;
        saturnInPlace = GameObject.Find("PlanetBoxSaturn").GetComponent<PlanetDrop>().inPlace;
        if (mercuryInPlace && earthInPlace && saturnInPlace) {
            Debug.Log("Success!");
        } else {
            Debug.Log("Failure!");
        }
    }

}
