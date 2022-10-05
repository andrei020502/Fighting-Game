using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetNameAndHP : MonoBehaviour
{
    public NameSystem playernames;
    public GameStatus gamestatus;
    public void handlebuttonclick()
    {
       gamestatus.player1Name = playernames.player1Name.text;
       gamestatus.player2Name = playernames.player2Name.text;
      
       Debug.Log(gamestatus.player1Name);
       SceneManager.LoadScene(2);

    } 
   
}
