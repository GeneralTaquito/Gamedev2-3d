using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform player;
    public float mousesensivity = 2f;
    float cameraVerticalRotation = 0f;
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float inputx = Input.GetAxis("Mouse X")*mousesensivity;
        float inputy = Input.GetAxis("Mouse Y")*mousesensivity;


        cameraVerticalRotation -= inputy;
        cameraVerticalRotation = Mathf.Clamp(cameraVerticalRotation, -90f, 90f);
        transform.localEulerAngles = Vector3.right * cameraVerticalRotation;


        player.Rotate(Vector3.up * inputx);
    }
}
