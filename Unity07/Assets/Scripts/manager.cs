using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    public GameObject ball;
    public Transform spawnPoint;


    private void Start()
    {
        // Oyuna baþladýðýmýzda güvenli bölgede baþlayalým
        ball.transform.position = spawnPoint.position;

    }
}
