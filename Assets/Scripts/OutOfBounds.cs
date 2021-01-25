using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    private float xBoundary = 250;
    private float yBoundary = 250;
    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > xBoundary)
        {
            Destroy(gameObject);
        }
        if(transform.position.y > yBoundary)
        {
            Destroy(gameObject);
        }
         if(transform.position.x < -xBoundary)
        {
            Destroy(gameObject);
        }
        if(transform.position.y < -yBoundary)
        {
            Destroy(gameObject);
        }
    }
}
