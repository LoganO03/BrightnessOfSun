using UnityEngine;

public class JournalManager : MonoBehaviour
{
    public GameObject Journal;
    public GameObject JournalIcon;
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
    }
}
