using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //bool isWalking = animator.GetBool("isWalking");

        bool forwardPressed = Input.GetKey("w");
        bool backwardPressed = Input.GetKey("s");
        bool leftPressed = Input.GetKey("a");
        bool rightPressed = Input.GetKey("d");
        bool spacePressed = Input.GetKey("space");
 
        //walk forwards
        //player presses W key
        if (forwardPressed)
        {
            //set isWalking to true
            animator.SetBool("isWalking", true);
        }
        //player releases W key
        if (!forwardPressed)
        {
            //set isWalking to false
            animator.SetBool("isWalking", false);
        }


        //walk backwards
        //player presses S key
        if (backwardPressed)
        {
            //set isWalking to true
            animator.SetBool("isWalkingBackwards", true);
        }
        //player releases S key
        if (!backwardPressed)
        {
            //set isWalking to false
            animator.SetBool("isWalkingBackwards", false);
        }

        //walk left
        //player presses A key
        if (leftPressed)
        {
            //set isWalking to true
            animator.SetBool("isWalkingLeft", true);
        }
        //player releases A key
        if (!leftPressed)
        {
            //set isWalking to false
            animator.SetBool("isWalkingLeft", false);
        }

        //walk right
        //player presses D key
        if (rightPressed)
        {
            //set isWalking to true
            animator.SetBool("isWalkingRight", true);
        }
        //player releases D key
        if (!rightPressed)
        {
            //set isWalking to false
            animator.SetBool("isWalkingRight", false);
        }


        //splashdown jump
        if(spacePressed)
        {
            //set isJumping to true
            animator.SetBool("isJumping", true);
        }
        if (!spacePressed)
        {
            //set isJumping to false
            animator.SetBool("isJumping", false);
        }
    }
}
