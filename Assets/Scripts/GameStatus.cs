using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class GameStatus : MonoBehaviour
{
   public string player1Name;
   public string player2Name;
   public int playermaxhp;
   public int player1HP;
   public int player2HP;
   public int playerturn;
   public int winner;
   


    public void NextScene()
    {
        SceneManager.LoadScene(1);
    }

    public void quitapp()
    {
        Application.Quit();
    }
    void Start()
    {
       DontDestroyOnLoad(gameObject);
       
        playerturn = 1;
    }
}

