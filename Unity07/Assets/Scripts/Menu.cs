using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    
   public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    } 
   
    public void QuitGame()
    {
        print("Exited The Game!!");
        Application.Quit();
    }
    
    public void ReturnToStart()
    {
        SceneManager.LoadScene("Start");
    }

    public void BackToStart()
    {
        SceneManager.LoadScene("Start");
    }
}
