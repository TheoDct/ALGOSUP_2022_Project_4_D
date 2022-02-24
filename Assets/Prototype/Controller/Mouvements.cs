using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvements : MonoBehaviour
{

    public CharacterController control;
    public Transform groundCheck;

    public float groundDistance = 0.4f;

    public float speed = 12f;
    public float RunningSpeed = 18f;
    public float gravity = -9.81f;
    public float jumpHight = 2f;
    public LayerMask groundMask;

    private Vector3 move;
    private Vector3 velocity;
    private bool isGrounded;
    private bool isRunning;
    private float x, z, sp;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        isRunning = Input.GetKey(KeyCode.LeftShift);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
            velocity.x = 0f;
            velocity.z = 0f;
        }

        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        move = transform.right * x + transform.forward * z;

        if (isRunning)
        {
            sp = RunningSpeed;
        }
        else
        {
            sp = speed;
        }

        if (isGrounded)
        {
            control.Move(move * sp * Time.deltaTime);
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.x = move.x * sp;
            velocity.z = move.z * sp;
            velocity.y = Mathf.Sqrt(jumpHight * -2f * gravity);

        }

        velocity.y += gravity * Time.deltaTime;

        control.Move(velocity * Time.deltaTime);

    }

}
