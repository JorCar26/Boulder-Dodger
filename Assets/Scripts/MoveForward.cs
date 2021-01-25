using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed;
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    void Start()
    {
        timerIsRunning = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                Destroy(gameObject);
            }
        }
        if(transform.position.x > -40 && transform.position.x <= 30)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if(transform.position.y  > -20 && transform.position.y <= 15)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
    }
}
