using UnityEngine;
using TMPro;
using System;

public class UIManager : MonoBehaviour
{
    public GameObject Journal;
    public GameObject Thermometer;
    public TMP_Text ThermometerText;
    public GameObject JournalIcon;
    public GameObject TempIcon;
    public TMP_Text MineralCount;
    public float Temperature;

    void Start()
    {
        
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)) {
            GetComponent<PlayerMovement>().enabled = !GetComponent<PlayerMovement>().enabled;
            if (GetComponent<PlayerMovement>().enabled) {
                Cursor.lockState = CursorLockMode.Locked;
                JournalIcon.gameObject.SetActive(true);
                TempIcon.gameObject.SetActive(true);
                Journal.LeanMoveLocalY(-410, 0.5f).setEaseOutExpo().setOnComplete(OnCompleteJournal);
                return;
            }
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            JournalIcon.gameObject.SetActive(false);
            TempIcon.gameObject.SetActive(false);
            Journal.gameObject.SetActive(true);
            Journal.LeanMoveLocalY(0, 0.5f).setEaseOutExpo().delay = 0.1f;
        }

        if (Input.GetKeyDown(KeyCode.T)) {
            if (!Journal.gameObject.activeSelf) {
                if (Thermometer.gameObject.activeSelf) {
                    Thermometer.LeanMoveLocalY(-230, 0.5f).setEaseOutExpo().setOnComplete(OnCompleteTemp);
                    return;
                }
                Thermometer.gameObject.SetActive(true);
                ThermometerText.text = $"{Temperature}°F";
                Thermometer.LeanMoveLocalY(0, 0.5f).setEaseOutExpo().delay = 0.1f;
            }
        }
    }

    void OnCompleteTemp()
    {
        Thermometer.SetActive(false);
    }

    void OnCompleteJournal()
    {
        Journal.SetActive(false);
    }
}