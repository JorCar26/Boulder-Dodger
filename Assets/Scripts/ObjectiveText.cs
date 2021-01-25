using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectiveText : MonoBehaviour
{
    public Text objectiveText;
    AudioSource startChime;
    public AudioClip start;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2);
        objectiveText.text = "Dodge the boulders for 10 Seconds!";
        startChime = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        startChime.PlayOneShot(start, 1.0f);
    }
}
