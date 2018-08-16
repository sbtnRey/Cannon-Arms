using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using VRTK;

public class gameController : MonoBehaviour {
    // create ship array
    public GameObject [] ship;
    public VRTK_ControllerEvents rightControllerEvents;
    public VRTK_ControllerEvents leftControllerEvents;


    public int shipCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    public TextMesh scoreText;
    public TextMesh restartText;
    public TextMesh gameOverText;


    private int score;
    private bool gameOver;
    private bool restart;



    void Start()
    {
        score = 0;
        UpdateScore();
        StartCoroutine(SpawnWaves());
        gameOver = false;
        restart = false;
        restartText.text = "";
        gameOverText.text = "";

    }

    void Update()
    {
        if(restart)
        {
            if (rightControllerEvents.triggerPressed || leftControllerEvents.triggerPressed)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

       
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < shipCount; i++)
            {

                // Randomize 0-3, based on the value. choose a side
                // replicate below for each side

                //replace spawnValues with hardcodded vector3 space values
                // if score is over 100 start spawning other boats
                int randomSide = Random.Range(0, 4);

                if (randomSide == 0)
                {
                    Vector3 spawnPosition = new Vector3(Random.Range(-25, 25), -1, 25);
                    Quaternion spawnRotation = Quaternion.identity;
                    AudioSource alive = GetComponent<AudioSource>();
                    alive.Play();
                    waveCounter(score, spawnPosition, spawnRotation);
                    // Instantiate(ship[0], spawnPosition, spawnRotation);
                    //print(score);
                    yield return new WaitForSeconds(spawnWait);
                } else if (randomSide == 1) {
                    Vector3 spawnPosition = new Vector3(Random.Range(-25, 25), -1, -25);
                    Quaternion spawnRotation = Quaternion.identity;
                    AudioSource alive = GetComponent<AudioSource>();
                    alive.Play();
                    waveCounter(score, spawnPosition, spawnRotation);
                    //Instantiate(ship[1], spawnPosition, spawnRotation);
                    //print(score);
                    yield return new WaitForSeconds(spawnWait);
                } else if (randomSide == 2) {
                    Vector3 spawnPosition = new Vector3(25, -1, Random.Range(-25, 25));
                    Quaternion spawnRotation = Quaternion.identity;
                    AudioSource alive = GetComponent<AudioSource>();
                    alive.Play();
                    waveCounter(score, spawnPosition, spawnRotation);
                    //Instantiate(ship[2], spawnPosition, spawnRotation);
                    //print(score);
                    yield return new WaitForSeconds(spawnWait);
                } else {
                    Vector3 spawnPosition = new Vector3(-25, -1, Random.Range(-25, 25));
                    Quaternion spawnRotation = Quaternion.identity;
                    AudioSource alive = GetComponent<AudioSource>();
                    alive.Play();
                    waveCounter(score, spawnPosition, spawnRotation);
                    //Instantiate(ship[3], spawnPosition, spawnRotation);
                    //print(score);
                    yield return new WaitForSeconds(spawnWait);
                }

            }
            yield return new WaitForSeconds(waveWait);

            if (gameOver)
            {
                //print("gameOver");
                restartText.text = "Shoot To Restart";
                restart = true;
                break;
            }
        }
    }

    public void GameOver()
    {
        gameOverText.text = "Game Over";
        gameOver = true;
    }

    public void waveCounter(int score, Vector3 spawnPosition, Quaternion spawnRotation)
    {

        int randomShip; 

        if (score >= 0 && score < 1000)
        {
            Instantiate(ship[0], spawnPosition, spawnRotation);
        } else if (score >= 1000 && score < 2500) {
            spawnWait = .5F;
            randomShip = Random.Range(0, 2);
            if (randomShip == 0)
            {
                Instantiate(ship[0], spawnPosition, spawnRotation);
            } else {
                Instantiate(ship[1], spawnPosition, spawnRotation);
            }
        } else if (score >= 2500 && score < 5000) {
            spawnWait = .2F;
            randomShip = Random.Range(0, 3);
            if (randomShip == 0)
            {
                Instantiate(ship[0], spawnPosition, spawnRotation);
            }
            else if (randomShip == 1)
            {
                Instantiate(ship[1], spawnPosition, spawnRotation);
            }
            else
            {
                Instantiate(ship[2], spawnPosition, spawnRotation);
            }
        } else if (score >= 5000 && score < 7500) {
            spawnWait = .1F;
            randomShip = Random.Range(0, 4);
            if (randomShip == 0)
            {
                Instantiate(ship[0], spawnPosition, spawnRotation);
            }
            else if (randomShip == 1)
            {
                Instantiate(ship[1], spawnPosition, spawnRotation);
            }
            else if (randomShip == 2)
            {
                Instantiate(ship[2], spawnPosition, spawnRotation);
            }
            else
            {
                Instantiate(ship[3], spawnPosition, spawnRotation);
            }
        } else if (score >= 7500) {
            randomShip = Random.Range(0, 5);
            if (randomShip == 0)
            {
                Instantiate(ship[0], spawnPosition, spawnRotation);
            }
            else if (randomShip == 1)
            {
                Instantiate(ship[1], spawnPosition, spawnRotation);
            }
            else if (randomShip == 2)
            {
                Instantiate(ship[2], spawnPosition, spawnRotation);
            }
            else if (randomShip == 3)
            {
                Instantiate(ship[3], spawnPosition, spawnRotation);
            } else
            {
                Instantiate(ship[4], spawnPosition, spawnRotation);
            }
        }
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        //scoreText = GetComponent<TextMesh>();
        scoreText.text = "" + score;
    }
}
