using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;
    private GameObject player;
    private Vector3 playerlocation;
    // Start is called before the first frame update

    void Awake()
    {
        //Check if instance already exists
        if (instance == null)

            //if not, set instance to this
            instance = this;

        //If instance already exists and it's not this:
        else if (instance != this)

            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);

        player = GameObject.Find("Player");

    }

     public void Teleport(float x, float y)
    {
        player.transform.position = new Vector3(x, y, 0);
    }

    public void EnterCombat()
    {
        playerlocation = player.transform.position;

        SceneManager.LoadScene(1);
    }

    public void ExitCombat()
    {
        SceneManager.LoadScene(0);

        player.transform.position = playerlocation;
    }

    



    

        //void Start()
    //{
        
    //}

    // Update is called once per frame
   // void Update()
    //{
   // }


}
