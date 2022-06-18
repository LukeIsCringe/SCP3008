using UnityEngine;

public class characterMovement : MonoBehaviour
{
    public CharacterController controller;


    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    Vector3 velocity;


    void Update()
    {
        //ground check stuff
        GameObject groundChecker = GameObject.Find("GroundCheck");

        if (groundChecker.GetComponent<groundCheck>().isGrounded == true && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        //movement shit 
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z; 

        controller.Move(move * speed * Time.deltaTime);


        //jump
        if(Input.GetKeyDown(KeyCode.Space) && groundChecker.GetComponent<groundCheck>().isGrounded == true)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }

        //gravity stuff
        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        //sprint
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 18f;
        }
        else
        {
            speed = 12f;
        }


    }
}
