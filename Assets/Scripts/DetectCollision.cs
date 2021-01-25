using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DetectCollision : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    public AudioClip audioClip2;
    public ParticleSystem explosionEffect;
    public Text gameOvertext;

    private int count;

void Start()
{
}
void OnTriggerEnter2D(Collider2D other)
   {
       Debug.Log("Hit");
       Destroy(other.gameObject);
       count +=1;
        audioSource.PlayOneShot(audioClip2, 0.7f);
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(audioClip, 0.8f);

   }
    void Explosion()
    {
        Instantiate(explosionEffect,gameObject.transform.position, Quaternion.identity);
        explosionEffect.Stop();
    }
    // Update is called once per frame
    void Update()
    {
        if( count == 1)
        {
            Explosion();
            count +=1;
            gameOvertext.text = "GameOver!";
        }
        if(Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
