using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour {
    public Camera PlayerCamera;
    public float WalkSpeed;
    public float RunSpeed;
    public float JumpPower = 7f;
    public float Gravity;
    public float LookSpeed = 2f;
    public float LookXLimit = 45f;
    public float DefaultHeight = 2f;
    public float CrouchHeight = 1f;
    public float CrouchSpeed = 3f;
    public int MineralCount = 0;
    public AudioSource WalkAudio;

    private Vector3 MoveDirection = Vector3.zero;
    private float RotationX = 0;
    private CharacterController CharacterController;

    private bool CanMove = true;

    bool wasGrounded = true;

    void Start() {
        CharacterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update() {
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);
        bool isRunning = Input.GetKey(KeyCode.LeftShift);
        float curSpeedX = CanMove ? (isRunning ? RunSpeed : WalkSpeed) * Input.GetAxis("Vertical") : 0;
        float curSpeedY = CanMove ? (isRunning ? RunSpeed : WalkSpeed) * Input.GetAxis("Horizontal") : 0;
        float movementDirectionY = MoveDirection.y;
        MoveDirection = (forward * curSpeedX) + (right * curSpeedY);
        if (Input.GetButton("Jump") && CanMove && CharacterController.isGrounded) {
            MoveDirection.y = JumpPower;
        } else {
            MoveDirection.y = movementDirectionY;
        }
        if (!CharacterController.isGrounded) {
            MoveDirection.y -= Gravity * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.R) && CanMove) {
            CharacterController.height = CrouchHeight;
            WalkSpeed = CrouchSpeed;
            RunSpeed = CrouchSpeed;
        } else {
            CharacterController.height = DefaultHeight;
            WalkSpeed = 10f;
            RunSpeed = 20f;
        }
        CharacterController.Move(MoveDirection * Time.deltaTime);
        if (CanMove && !PauseMenu.Paused) {
            RotationX += -Input.GetAxis("Mouse Y") * LookSpeed;
            RotationX = Mathf.Clamp(RotationX, -LookXLimit, LookXLimit);
            PlayerCamera.transform.localRotation = Quaternion.Euler(RotationX, 0, 0);
            transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * LookSpeed, 0);
        }
        
        if (CharacterController.isGrounded) {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) {
                WalkAudio.enabled = true;
            } else {
                WalkAudio.enabled = false;
            }

            // Detect landing while holding W
            if (!wasGrounded && Input.GetKey(KeyCode.W)) {
                WalkAudio.enabled = true;
            }
        } else {
            WalkAudio.enabled = false;
        }

        wasGrounded = CharacterController.isGrounded;

    }

    public void IncreaseCount() {
        MineralCount += 1;
        GetComponent<UIManager>().MineralCount.text = "Minerals: " + MineralCount;
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Mineral")) {
            IncreaseCount();
            Destroy(collision.gameObject);
        }
    }
}