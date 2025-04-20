using UnityEngine;
using UnityEngine.EventSystems;

public class PlanetDrop : MonoBehaviour, IDropHandler
{

    public void OnDrop(PointerEventData eventData) {
        if (eventData.pointerDrag != null) {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }

}
