using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    public GameObject ball;
    public Transform spawnPoint;


    private void Start()
    {
        // Oyuna ba�lad���m�zda g�venli b�lgede ba�layal�m
        ball.transform.position = spawnPoint.position;

    }
}
