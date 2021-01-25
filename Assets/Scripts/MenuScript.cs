using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public Text pressSpace;
    // Start is called before the first frame update
    void Start()
    {
        pressSpace.text = "Press Space Bar to Begin";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
