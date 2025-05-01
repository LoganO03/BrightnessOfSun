using TMPro;
using UnityEngine;

interface IInteractable {
    public void Interact();
}

public class Interactor : MonoBehaviour
{
    public Transform InteractorSource;
    public TMP_Text ReturnText;
    public GameObject Player;
    public float InteractRange;

    void Update()
    {
        Ray ray = new Ray(InteractorSource.position, InteractorSource.forward);
        if (Physics.Raycast(ray, out RaycastHit hitInfo, InteractRange) && Player.GetComponent<PlayerMovement>().mineralCount == 1) {
            if (hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObj)) {
                ReturnText.gameObject.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E)) {
                    interactObj.Interact();
                }
            }
        } else {
            ReturnText.gameObject.SetActive(false);
        }
    }
}
