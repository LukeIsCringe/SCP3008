using UnityEngine;

public class groundCheck : MonoBehaviour
{
    public bool isGrounded = false;

    public void OnTriggerEnter(Collider other)
    {
        print("on the ground");

        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            print("ground check actually fucking working omg I wanna shoot myself");
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}