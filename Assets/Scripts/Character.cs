using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    public float speed;
    public float mouseSpeedX;
    public float mouseSpeedY;

    private Rigidbody rb;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        // mouse movement
        yaw += mouseSpeedX * Input.GetAxis("Mouse X");
        pitch -= mouseSpeedY * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0);
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 mov = new Vector3(0, 0, 1);
            mov = mov.normalized * speed * Time.deltaTime;
            rb.MovePosition(rb.position + transform.forward * mov.z);
        }

        // move backward
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 mov = new Vector3(0, 0, -1);
            mov = mov.normalized * speed * Time.deltaTime;
            rb.MovePosition(rb.position + transform.forward * mov.z);
        }

        // strafe left
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 mov = new Vector3(-1, 0, 0);
            mov = mov.normalized * speed * Time.deltaTime;
            rb.MovePosition(rb.position + transform.right * mov.x);
        }

        // strafe right
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 mov = new Vector3(1, 0, 0);
            mov = mov.normalized * speed * Time.deltaTime;
            rb.MovePosition(rb.position + transform.right * mov.x);
        }
    }

    
}
