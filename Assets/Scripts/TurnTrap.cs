using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTrap : MonoBehaviour
{
    public float turnSpeed;
    public Transform pivot; // Kap�n�n merkez noktas� olarak kullan�lacak bo� nesne

    void Start()
    {
        
    }

   
    void Update()
    {
        transform.RotateAround(pivot.position, Vector3.right, turnSpeed * Time.deltaTime);
    }
}
