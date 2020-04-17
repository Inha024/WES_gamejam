using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlivePlayerMovement : MonoBehaviour
{
    private float speed = 10; //speed is 10f
    public bool Grounded;//Grounded is a bool
    public bool DoubleJump = false;
    public bool DoubleJumpCounter;
    private Rigidbody2D rb2d;//rb2d is Rigidbody2d
    public GameObject Groundedcheck;//Groundcheck object
    public void Move(Vector3 direction) //Move function based on direction
    {
        GetComponent<Transform>().position += direction * speed * Time.deltaTime; //Change transform position in the direction multiplied by speed and seconds
    }


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();//rb2d gets Rigidbody2D
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))//If A is pressed
        {
            Move(Vector3.left);//Move in the Vector3 direction
        }
        if (Input.GetKey(KeyCode.D))
        {
            Move(Vector3.right);
        }
        if (Input.GetKeyDown(KeyCode.Space) && Grounded) //If you're Grounded and press Space
        {
            rb2d.velocity = Vector3.up * 15; //Add a force to move you upwards AKA Jump
            Invoke("DoubleJumpTrue", 0.1f);
        }
        if (Input.GetKeyDown(KeyCode.Space) && DoubleJump && DoubleJumpCounter) //If you're Grounded and press Space
        {
            rb2d.velocity = Vector3.up * 15; //Add a velocity to move you upwards AKA DoubleJump
            DoubleJump = false;
            DoubleJumpCounter = false;
        }

        RaycastHit2D groundDetection = Physics2D.Raycast(Groundedcheck.transform.position, Vector3.down, 0.01f); //Use RaycastHit2D downwards to check if you're Grounded

        if (groundDetection.collider != null) //If Ground is detected
        {
            Grounded = true;//You're Grounded
            DoubleJump = false;
            DoubleJumpCounter = true;
        }
        else
        {
            Grounded = false; //If ground is not detected, you're not Grounded
            Invoke("DoubleJumpTrue", 0.1f);
        }
    }

    public void DoubleJumpTrue()
    {
        DoubleJump = true;
    }
}
