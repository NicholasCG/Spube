using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    private float ScreenWidth;

    private void Start()
    {
        ScreenWidth = Screen.width;
   
    }
    // We maked this as "FixedUpdate because we
    // are using it to mess with physics.
    void FixedUpdate()
    {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        #if UNITY_EDITOR || UNITY_STANDALONE
        if ( Input.GetKey("d") )
        {
            RunCharacter(1.0f);
        }

        if (Input.GetKey("a"))
        {
            RunCharacter(-1.0f);
        }
        #endif

        #if UNITY_ANDROID && !UNITY_EDITOR
        int i = 0;
        while (i < Input.touchCount || Input.anyKey)
        {
            if(Input.GetTouch (i).position.x > ScreenWidth / 2)
            {
                RunCharacter(1.0f);
            }

            if (Input.GetTouch(i).position.x < ScreenWidth / 2)
            {
                RunCharacter(-1.0f);
            }
            ++i;
        }
        #endif

        if (rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }

    void RunCharacter(float horizontalInput)
    {
        rb.AddForce(horizontalInput * sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
