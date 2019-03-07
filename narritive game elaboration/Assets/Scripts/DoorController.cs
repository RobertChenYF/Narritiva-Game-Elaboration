using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    // Start is called before the first frame update

    public float teleportX;

    public float teleportY;

    public bool faceupordown; // true = face up;

    private bool playerfaceup;

    private bool playerfacedown;

    private GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerMovement.FaceDirection == 0)
        {
            playerfacedown = true;
        }
        else if (PlayerMovement.FaceDirection == 1)
        {
            playerfaceup = true;
        }
        else
        {
            playerfacedown = false;
            playerfaceup = false;
        }






    }

    public void OnCollisionEnter2D(Collision2D collision2D)
    {
       if(collision2D.gameObject.name == "Player")
        {

            if(faceupordown == true && playerfaceup == true)
            {
                Teleport();
            }
            else if(faceupordown == false && playerfacedown == true)
            {
                Teleport();
            }





            //Teleport();
           // Debug.Log("touch door");

        }
    }

    void Teleport()
    {
        player.transform.position = new Vector3(teleportX,teleportY,0);
    }
}
