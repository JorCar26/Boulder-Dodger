using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;

    public float xRange = 35.0f;
    public float yRange = 35.0f;


    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public Text timeText;
    public Text gameOverText;
    public Text nameText;
    public Text restartText;
    public bool gameOver;
    public AudioSource audioSource;
    public AudioClip audioClip;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("runTimer",2.0f);
        timeText.text = "";
        gameOverText.text = ("");
        gameOver = false;
        audioSource = GetComponent<AudioSource>();
        Invoke("playAudio", 2.0f);
    }

    void playAudio()
    {
        audioSource.Play();
    }
    void runTimer()
    {
        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if( transform.position.x < -xRange)
        {
            transform.position = new Vector2(-xRange, transform.position.y);
        }
        if( transform.position.x > xRange)
        {
            transform.position = new Vector2(xRange, transform.position.y);
        }
        if( transform.position.y < -yRange)
        {
            transform.position = new Vector2(transform.position.x, -yRange);
        }
        if( transform.position.y > yRange )
        {
            transform.position = new Vector2(transform.position.x, yRange);
        }

        Vector2 movement = new Vector2(horizontalInput, verticalInput);
 
        transform.Translate(movement * speed * Time.deltaTime);


        if (timerIsRunning)
        {
            
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                gameOverText.text = ("Congrats! You Survived!");
                nameText.text = ("Created by Jordan Carswell");
                gameOver = true;
                GetComponent<AudioSource>().clip = audioClip;
                audioSource.Play();
            }
        }
            if(gameOver == true)
                {
                    restartText.text = "Press R to Restart";
                    if(Input.GetKeyDown("r"))
                    {
                        SceneManager.LoadScene("SampleScene");
                    }
                }
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
