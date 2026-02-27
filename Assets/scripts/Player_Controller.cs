using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using System.Collections;
using System.Collections.Generic;

public class Player_Controller : MonoBehaviour
{
    public float Walkspeed = 10f;
    public float SprintSpeed = 20f;
    public float JumpF = 5f;
    public float GCD = 1.5f;
    public float LookSensX = 1f;
    public float LookSensY = 1f;
    public float Gravity = -9.8f;
    public float MinYLookAngle = -90f;
    public float MaxYLookAngle = 90f;
    private Vector3 velocity;
    public float verticalrotation = 0f;
    public Transform Playercam;
    private CharacterController characterController;

    void Awake()
    {
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        Vector3 movedirection = transform.forward * verticalMovement + transform.right * horizontalMovement;
        movedirection.Normalize();

        float speed = Walkspeed;
        if (Input.GetAxis("Sprint") > 0)
        {
            speed *= SprintSpeed;
        }

        characterController.Move(movedirection * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            velocity.y = JumpF;
        }
        else
        {
            velocity.y += Gravity * Time.deltaTime;
        }

        characterController.Move(velocity * Time.deltaTime);

        if(Playercam != null)
        {
            float mouseX = Input.GetAxis("Mouse X") * LookSensX;
            float mouseY = Input.GetAxis("Mouse Y") * LookSensY;

            verticalrotation -= mouseY;
            verticalrotation = Mathf.Clamp(verticalrotation, MinYLookAngle, MaxYLookAngle);

            Playercam.localRotation = Quaternion.Euler(verticalrotation, 0f, 0f);
            transform.Rotate(Vector3.up * mouseX);
        }
    }

    bool IsGrounded()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, Vector3.down, out hit, GCD))
        {
            return true;
        }
        return false;
    }

}
