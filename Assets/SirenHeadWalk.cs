using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SirenHeadWalk : MonoBehaviour
{
    CharacterController controller;

    public float gravity = -9.81f;
    public float speed = 3.0f;
   
    public float groundDisctance = 0.4f;
    public Transform groundCheck;
    public LayerMask groundMask;

    Vector3 velocity;  
    bool isGrounded;


    private void Start()
    {
        //controller = GetComponent<CharacterController>;
    }
    // Update is called once per frame
   /* void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDisctance, groundMask);


        if(isGrounded)
        {
            velocity.y = -2f;
        }

      Vector3 move =  (transform.forward * speed * Time.deltaTime);

        controller.Move(move);

       velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
       

        

    }*/


}
