using UnityEngine;
using UnityEngine.EventSystems;

public class PlanetDrop : MonoBehaviour, IDropHandler
{

    public string planetName;
    public bool inPlace = false;

    public void OnDrop(PointerEventData eventData) {
        if (eventData.pointerDrag != null) {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            if (gameObject.name == $"PlanetBox{planetName}") {
                if (eventData.pointerDrag.name == planetName) {
                    inPlace = true;
                } else {
                    inPlace = false;
                }
            }
        }
    }

}
