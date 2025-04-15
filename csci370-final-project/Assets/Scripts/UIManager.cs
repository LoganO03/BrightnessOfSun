using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject Journal;
    public GameObject Thermometer;
    public TMP_Text ThermometerText;
    public GameObject JournalIcon;
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
            } else {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            JournalIcon.gameObject.SetActive(!JournalIcon.gameObject.activeSelf);
            Journal.gameObject.SetActive(!Journal.gameObject.activeSelf);
        }
        if (Input.GetKeyDown(KeyCode.T)) {
            if (!Journal.gameObject.activeSelf) {
                Thermometer.gameObject.SetActive(!Thermometer.gameObject.activeSelf);
                ThermometerText.text = $"{Temperature}°F";
            }
        }
    }
}
