using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class GameStatus : MonoBehaviour
{
   public string player1Name;
   public string player2Name;
   
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void NextScene()
    {
        SceneManager.LoadScene(1);
    }

    public void quitapp()
    {
        Application.Quit();
    }
}

