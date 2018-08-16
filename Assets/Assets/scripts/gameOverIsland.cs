using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOverIsland : MonoBehaviour {

    private gameController gameController;



    private void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<gameController>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

    

        if (collision.gameObject.tag == "enemy01")
        {
            gameController.GameOver();
        }

        if (collision.gameObject.tag == "enemy02")
        {
            gameController.GameOver();
        }
        if (collision.gameObject.tag == "enemy03")
        {
            gameController.GameOver();
        }
        if (collision.gameObject.tag == "enemy04")
        {
            gameController.GameOver();
        }
        if (collision.gameObject.tag == "enemy05")
        {
            gameController.GameOver();
        }


    }
}
