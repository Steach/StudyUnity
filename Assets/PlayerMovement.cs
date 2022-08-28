
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float runSpeed = 25f;
    public float strafeSpeed = 25f;
    public float jumpForce = 10f;

    protected bool strafeLeft = false;
    protected bool strafeRight = false;
    protected bool moveForward = false;
    protected bool moveBack = false;
    protected bool doJump = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("a"))
        {
            strafeLeft = true;
        } else
        {
            strafeLeft = false;
        }

        if(Input.GetKey("d"))
        {
            strafeRight = true;
        } else
        {
            strafeRight = false;
        }

        if(Input.GetKey("w"))
        {
            moveForward = true;
        } else
        {
            moveForward = false;
        }

        if(Input.GetKey("s"))
        {
            moveBack = true;
        } else
        {
            moveBack = false;
        }

        if(Input.GetKey("space"))
        {
            doJump = true;
        }
    }

    void FixedUpdate()
    {
        if(moveForward)
        {
            //rb.AddForce(runSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            rb.AddForce(Vector3.forward * runSpeed * Time.deltaTime, ForceMode.VelocityChange);
        }

        if(moveBack)
        {
            //rb.AddForce(runSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            rb.AddForce(Vector3.back * runSpeed * Time.deltaTime, ForceMode.VelocityChange);
        }

        if(strafeLeft)
        {
            //rb.AddForce(runSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            rb.AddForce(Vector3.left * runSpeed * Time.deltaTime, ForceMode.VelocityChange);
        }

        if(strafeRight)
        {
            //rb.AddForce(runSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            rb.AddForce(Vector3.right * runSpeed * Time.deltaTime, ForceMode.VelocityChange);
        }

        if(doJump)
        {
            rb.AddForce(Vector3.up * jumpForce * Time.deltaTime, ForceMode.Impulse);
            doJump = false;
        }
    }
}
