using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyShips : MonoBehaviour {

    public int score;
    private gameController gameController;
    public GameObject[] explosion;
    
    

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
            Instantiate(explosion[0], collision.transform.position, collision.transform.rotation);
            Destroy(collision.gameObject);
            AudioSource shoot = GetComponent<AudioSource>();
            shoot.Play();

            gameController.AddScore(score);
        }
        
        if (collision.gameObject.tag == "enemy02")
        {
            Instantiate(explosion[1], collision.transform.position, collision.transform.rotation);
            Destroy(collision.gameObject);
            AudioSource shoot = GetComponent<AudioSource>();
            shoot.Play();
            gameController.AddScore(score);
        }
        if (collision.gameObject.tag == "enemy03")
        {
            Instantiate(explosion[2], collision.transform.position, collision.transform.rotation);
            Destroy(collision.gameObject);
            AudioSource shoot = GetComponent<AudioSource>();
            shoot.Play();
            gameController.AddScore(score);
        }
        if (collision.gameObject.tag == "enemy04")
        {
            Instantiate(explosion[3], collision.transform.position, collision.transform.rotation);
            Destroy(collision.gameObject);
            AudioSource shoot = GetComponent<AudioSource>();
            shoot.Play();
            gameController.AddScore(score);
        }
        if (collision.gameObject.tag == "enemy05")
        {
            Instantiate(explosion[4], collision.transform.position, collision.transform.rotation);
            Destroy(collision.gameObject);
            AudioSource shoot = GetComponent<AudioSource>();
            shoot.Play();
            gameController.AddScore(score);
        }
        
    }
}
