using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class WASDmanager : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody RB;

    void Start()
    {

    }

    void Update()
    {
        MovePlayer();
    }
        
    void MovePlayer()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");

        Vector3 worldDir = new Vector3(HorizontalInput, 0, VerticalInput) * speed;
        transform.position += worldDir * Time.deltaTime;

        Vector3 localDir = transform.InverseTransformDirection(worldDir.normalized);
    }
        
}
