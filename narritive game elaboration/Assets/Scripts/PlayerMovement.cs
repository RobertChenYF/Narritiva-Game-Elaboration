using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public float playerMovementSpeed;
    public Animator animator;
    public static int FaceDirection;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {

            transform.position += new Vector3(playerMovementSpeed*Time.deltaTime, 0);

            FaceDirection = 2;
            walking();

        }
        else if (Input.GetAxis("Horizontal") < 0)
        {

            transform.position += new Vector3(-playerMovementSpeed * Time.deltaTime, 0);

            FaceDirection = 3;
            walking();
        }
        else if (Input.GetAxis("Vertical") > 0)
        {

            transform.position += new Vector3(0, playerMovementSpeed * Time.deltaTime);

            FaceDirection = 1;
            walking();

        }
        else if (Input.GetAxis("Vertical") < 0)
        {

            transform.position += new Vector3(0, -playerMovementSpeed * Time.deltaTime);

            FaceDirection = 0;
            walking();
        }
        else {
            animator.SetBool("ifWalk", false);
        }
        animator.SetInteger("FaceDirection", FaceDirection);

        void walking()
        {
            animator.SetBool("ifWalk", true);
        }


    }
}
