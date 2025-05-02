using UnityEngine;

public class UIManagerPlanet : MonoBehaviour
{
    public GameObject Journal;
    public GameObject JournalIcon;
    
    void Start() {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)) {
            if (Journal.activeSelf == false) {
                JournalIcon.gameObject.SetActive(false);
                Journal.gameObject.SetActive(true);
                Journal.LeanMoveLocalY(0, 0.5f).setEaseOutExpo().delay = 0.1f;
                return;
            }
            JournalIcon.gameObject.SetActive(true);
            Journal.LeanMoveLocalY(-410, 0.5f).setEaseOutExpo().setOnComplete(OnCompleteJournal);
        }
    }

    void OnCompleteJournal()
    {
        Journal.SetActive(false);
    }
}