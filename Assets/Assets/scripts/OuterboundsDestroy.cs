using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuterboundsDestroy : MonoBehaviour {

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
            Destroy(collision.gameObject);


        }

        if (collision.gameObject.tag == "enemy02")
        {
            Destroy(collision.gameObject);

        }
        if (collision.gameObject.tag == "enemy03")
        {
            Destroy(collision.gameObject);

        }
        if (collision.gameObject.tag == "enemy04")
        {
            Destroy(collision.gameObject);

        }
        if (collision.gameObject.tag == "enemy05")
        {
            Destroy(collision.gameObject);

        }

    }
}
