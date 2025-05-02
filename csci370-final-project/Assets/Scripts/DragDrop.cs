using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler {
    [SerializeField] private Canvas Canvas;
    private RectTransform RectTransform;
    private CanvasGroup CanvasGroup;

    private void Awake() {
        RectTransform = GetComponent<RectTransform>();
        CanvasGroup = GetComponent<CanvasGroup>();
    }
    
    public void OnBeginDrag(PointerEventData eventData) {
        CanvasGroup.alpha = 0.6f;
        CanvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData) {
        RectTransform.anchoredPosition += eventData.delta / Canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData) {
        CanvasGroup.alpha = 1f;
        CanvasGroup.blocksRaycasts = true;
    }
}