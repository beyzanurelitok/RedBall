using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ball : MonoBehaviour
{

    private Rigidbody rb;
    public float movementSpeed = 7f;
    public float jumpForce = 5f;
    
    public float jumpTime;
    public int ballHP = 10;
    //private float rotationAngle = 0f;
    //public GameObject Trigger;
    //private AudioSource audioSource;
    //private bool hasPlayed = false;


    void Start()
    {
       
        rb = GetComponent<Rigidbody>();
       
        //audioSource = GetComponent<AudioSource>();

        //audioSource.Stop();
        //Cursor.lockState = CursorLockMode.Locked; 


        jumpTime = 0;

    }
    private void FixedUpdate()
    {
        transform.Translate(Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime, 0, Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime);

    }
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && jumpTime < Time.time)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumpTime = Time.time + 1f;
        }
        if (ballHP <= 0)
        {
            GameOver();
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Positive"))
        {

            Destroy(collision.gameObject);
            ballHP += 1;
        }
        else if (collision.gameObject.CompareTag("Negative"))
        {

            Destroy(collision.gameObject);
            ballHP -= 1;
        }
        if (collision.gameObject.CompareTag("Trap"))
        {
            ballHP -= 1;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("End"))
        {
            SceneManager.LoadScene("Start");
        }
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("") && !hasPlayed)
    //    {
    //        audioSource.Play();
    //        hasPlayed = true;
    //        print("1");
    //    }
    //}

    //void Respawn()
    //{

    //    manager managerScript = FindObjectOfType<manager>();
    //    transform.position = managerScript.spawnPoint.position;
    //    ballHP = 10; 
    //}

    void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
