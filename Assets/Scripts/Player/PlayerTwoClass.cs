using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerTwoClass : MonoBehaviour
{
    [Range(1, 50)]
    public float speed;

    [Range(1, 25)]
    public float jumpVelocity;

    public Transform groundChecker;
    private float groundDist = 0.4f;
    public LayerMask groundMaskChecker;

    private bool isGrounded;
    private Vector3 velocity;

    private PlayerInputKeys playerInputKeys;
    private InputAction inputAction;

    private void Awake()
    {
        playerInputKeys = new PlayerInputKeys();
    }

    private void OnEnable()
    {
        inputAction = playerInputKeys.PlayerTwoInput.Movement;
        inputAction.Enable();

        playerInputKeys.PlayerTwoInput.Movement.Enable();
    }
    private void OnDisable()
    {
        inputAction.Disable();
        playerInputKeys.PlayerTwoInput.Movement.Disable();
    }

    void Update()
    {
        Vector2 vecInput = playerInputKeys.PlayerTwoInput.Movement.ReadValue<Vector2>();

        Vector3 Movement = new Vector3(vecInput.x, 0.0f, vecInput.y);
        transform.position += Movement * speed * Time.deltaTime;
        /*
        float xDir = Input.GetAxis("Horizontal");
        float yDir = Input.GetAxis("Vertical");

        Vector3 Movement = new Vector3(xDir, 0.0f, yDir);

        isGrounded = Physics.CheckSphere(groundChecker.position, groundDist, groundMaskChecker);

        if (isGrounded && velocity.y < 0)
            velocity.y = 0.0f;

        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
            velocity.y = Mathf.Sqrt(jumpVelocity * -2f * -9.81f);
 
        if (!isGrounded)
            velocity.y += -9.81f * Time.deltaTime;

        transform.position += Movement * speed * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;
        */
    }
}
