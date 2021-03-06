using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    public float speed;
    public float mouseSpeedX;
    public float mouseSpeedY;

    public GameObject camera;

    private Rigidbody rb;

    public float yaw;
    public float pitch;
    private bool isWalking = false;

    private float controls = 4.55f;
    public bool controlsTimer = false;

    public GameObject window;
    public GameObject brokenWindow;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        rb.freezeRotation = true;
        Cursor.lockState = CursorLockMode.Confined;

    }

    public void EnableControls()
    {
        controlsTimer = true;
    }



    // Update is called once per frame
    void Update()
    {
        if (controlsTimer && controls > 0)
        {
            controls -= Time.deltaTime;
        }
        rb.velocity = new Vector3(0, 0, 0);
        Cursor.visible = false;
        // mouse movement
        if (controls <= 0)
        {
            

            yaw += mouseSpeedX * Input.GetAxis("Mouse X");
            pitch -= mouseSpeedY * Input.GetAxis("Mouse Y");

            if (pitch > 90)
            {
                pitch = 90;
            }
            if (pitch < -90)
            {
                pitch = -90;
            }

            //also swap windows
            window.SetActive(false);
            brokenWindow.SetActive(true);
        }

        camera.transform.localEulerAngles = new Vector3(pitch, 0, 0);
        transform.eulerAngles = new Vector3(0, yaw, 0);


    }

    void FixedUpdate()
    {
        if (controls <= 0)
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

            // Player walking sound loop
            if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == -1)
            {
                if (isWalking == false)
                {
                    isWalking = true;
                    SoundManager.PlayPlayerWalk();
                }
            }
            else if (Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") == 0)
            {
                if (isWalking == true)
                {
                    SoundManager.PausePlayerWalk();
                    isWalking = false;
                }
            }
        }
    }


}
