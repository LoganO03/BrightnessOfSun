using UnityEngine;
using TMPro;
using Random = UnityEngine.Random;

public class UIManager : MonoBehaviour {
    GameObject Journal;
    GameObject JournalText;
    GameObject JournalIcon;
    public GameObject Thermometer;
    public TMP_Text ThermometerText;
    public GameObject TempIcon;
    public AudioSource TempAudio;
    public TMP_Text MineralCount;
    public TMP_Text MineralNotif;
    public float LowestTemp;
    public float HighestTemp;

    void Awake() {
        Journal = GameObject.Find("JournalCanvas/Journal");
        JournalText = GameObject.Find("JournalCanvas/Journal/Input");
        JournalIcon = GameObject.Find("JournalCanvas/JournalIcon");
        JournalText.SetActive(false);
    }

    void Update() {
        AudioSource JournalAudio = Journal.GetComponent<AudioSource>();
        if (!PauseMenu.Paused) {
            if (Input.GetKeyDown(KeyCode.Tab)) {
                JournalAudio.Play();
                GetComponent<PlayerMovement>().enabled = !GetComponent<PlayerMovement>().enabled;
                if (GetComponent<PlayerMovement>().enabled) {
                    Cursor.lockState = CursorLockMode.Locked;
                    JournalIcon.gameObject.SetActive(true);
                    TempIcon.gameObject.SetActive(true);
                    Journal.LeanMoveLocalY(-450, 0.5f).setEaseOutExpo().setOnComplete(OnCompleteJournal);
                    return;
                }
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                JournalIcon.gameObject.SetActive(false);
                TempIcon.gameObject.SetActive(false);
                JournalText.gameObject.SetActive(true);
                Thermometer.gameObject.SetActive(false);
                Journal.LeanMoveLocalY(0, 0.5f).setEaseOutExpo().delay = 0.1f;
            }
            if (Input.GetKeyDown(KeyCode.T)) {
                if (!JournalText.gameObject.activeSelf) {
                    if (Thermometer.gameObject.activeSelf) {
                        Thermometer.LeanMoveLocalY(-230, 0.5f).setEaseOutExpo().setOnComplete(OnCompleteTemp);
                        return;
                    }
                    Thermometer.gameObject.SetActive(true);
                    ThermometerText.text = "-----";
                    Thermometer.LeanMoveLocalY(0, 0.5f).setEaseOutExpo().delay = 0.1f;
                }
            }
        }
        if (Input.GetMouseButtonDown(0)) {
            if (Thermometer.gameObject.activeSelf) {
                TempAudio.Play();
                ThermometerText.text = $"{Random.Range(LowestTemp, HighestTemp):F1}°F";
            }
        }
        if (GetComponent<PlayerMovement>().MineralCount >= 10) {
            MineralNotif.gameObject.SetActive(true);
        }
    }

    void OnCompleteTemp() {
        Thermometer.SetActive(false);
    }

    void OnCompleteJournal() {
        JournalText.SetActive(false);
    }
}