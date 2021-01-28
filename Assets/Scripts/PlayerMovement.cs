using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb; //Reference to the RigidBody component caled "rb"

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Update is called once per frame
    void FixedUpdate ()
    {
   
  
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        


        //rb.AddForce(0, 0, forwardForce * Time.deltaTime);  //Add forwardForce on the z-axis

        if ( Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        if (rb.position.z == 470)
        {
            FindObjectOfType<GameManager>().EndGame();
        }


       
    }
}
