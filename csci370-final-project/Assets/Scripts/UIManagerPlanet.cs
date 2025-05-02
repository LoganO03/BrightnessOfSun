using UnityEngine;

public class UIManagerPlanet : MonoBehaviour {
    GameObject Journal;
    GameObject JournalText;
    GameObject JournalIcon;
    public GameObject VictoryCanvas;
    
    void Awake() {
        Journal = GameObject.Find("JournalCanvas/Journal");
        JournalText = GameObject.Find("JournalCanvas/Journal/Input");
        JournalIcon = GameObject.Find("JournalCanvas/JournalIcon");
    }
    
    void Start() {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    
    void Update() {
        if (Input.GetKeyDown(KeyCode.Tab)) {
            if (VictoryCanvas.gameObject.activeSelf) {
                return;
            }
            if (JournalText.activeSelf == false) {
                JournalIcon.gameObject.SetActive(false);
                JournalText.gameObject.SetActive(true);
                Journal.LeanMoveLocalY(0, 0.5f).setEaseOutExpo().delay = 0.1f;
                return;
            }
            JournalIcon.gameObject.SetActive(true);
            Journal.LeanMoveLocalY(-410, 0.5f).setEaseOutExpo().setOnComplete(OnCompleteJournal);
        }
    }

    void OnCompleteJournal() {
        JournalText.gameObject.SetActive(false);
    }
}