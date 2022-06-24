#if ENABLE_INPUT_SYSTEM 
using UnityEngine.InputSystem;
#endif

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -10f;
    public float jumpHeight = 2f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    public AudioSource walkingSFX;
    public GameObject teleportingTarget;

    Vector3 velocity;
    bool isGrounded;

    private bool movementControllerDisabled = false;

#if ENABLE_INPUT_SYSTEM
    InputAction movement;
    InputAction jump;

    void Start()
    {
        movement = new InputAction("PlayerMovement", binding: "<Gamepad>/leftStick");
        movement.AddCompositeBinding("Dpad")
            .With("Up", "<Keyboard>/w")
            .With("Up", "<Keyboard>/upArrow")
            .With("Down", "<Keyboard>/s")
            .With("Down", "<Keyboard>/downArrow")
            .With("Left", "<Keyboard>/a")
            .With("Left", "<Keyboard>/leftArrow")
            .With("Right", "<Keyboard>/d")
            .With("Right", "<Keyboard>/rightArrow");
        
        jump = new InputAction("PlayerJump", binding: "<Gamepad>/a");
        jump.AddBinding("<Keyboard>/space");

        if(movementControllerDisabled == false)
        {
            movement.Enable();
            jump.Enable();
        }
    }
#endif

    // Update is called once per frame
    void Update()
    {
        float x;
        float z;
        bool jumpPressed = false;

#if ENABLE_INPUT_SYSTEM
        var delta = movement.ReadValue<Vector2>();
        x = delta.x;
        z = delta.y;
        jumpPressed = Mathf.Approximately(jump.ReadValue<float>(), 1);
#else
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        jumpPressed = Input.GetButtonDown("Jump");
#endif

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if(controller.isGrounded == true && controller.velocity.magnitude > 0.5f && walkingSFX.isPlaying == false)
        {
            walkingSFX.volume = Random.Range(0.2f, 0.3f);
            walkingSFX.pitch = Random.Range(0.8f, 1.1f);
            walkingSFX.Play();
        }

        if(jumpPressed && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        
    }

    public void teleportingPosition()
    {
        StartCoroutine(TeleportCountDown());
    }

    IEnumerator TeleportCountDown()
    {
        movementControllerDisabled = true;
        yield return new WaitForSeconds(0.1f);
        gameObject.transform.position = new Vector3(-7, 1.3f, -14);
        gameObject.transform.eulerAngles = new Vector3(0, 98.75f, 0);
        yield return new WaitForSeconds(0.1f);
        movementControllerDisabled = false;
    }
}
