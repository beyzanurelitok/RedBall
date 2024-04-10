using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject ball;
    public GameObject animations;
    public GameObject animations2;

    private bool hasPlayed = false;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball") && !hasPlayed)
        {
            audioSource.Play();
            hasPlayed = true;
            int ballHP = ball.GetComponent<ball>().ballHP;

            if (ballHP >= 8)
            {
                animations.SetActive(true);
                animations2.SetActive(true);
            }
            else if (ballHP <= 8)
            {
                animations2.SetActive(true);
            }

            
            
        }
    }

}
