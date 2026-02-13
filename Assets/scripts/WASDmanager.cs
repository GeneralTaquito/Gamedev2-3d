using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class WASDmanager : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody RB;

    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 vel = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.A))
        {
            vel.x = -speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            vel.z = -speed;
        }
        if (Input.GetKey(KeyCode.W))
        {
            vel.z = speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            vel.x = speed;
        }
        RB.linearVelocity = vel;


        float mouseX = mousePos.x;
        float mousey = mousePos.y;
    }
        
}
