using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTrap : MonoBehaviour
{
    public float turnSpeed;
    public Transform pivot; // Kapýnýn merkez noktasý olarak kullanýlacak boþ nesne

    void Start()
    {
        
    }

   
    void Update()
    {
        transform.RotateAround(pivot.position, Vector3.right, turnSpeed * Time.deltaTime);
    }
}
