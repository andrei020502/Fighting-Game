using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetNameandHP : MonoBehaviour
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
   public void handlebutton50()
   {
    gamestatus.player1HP = 50;
    gamestatus.player2HP = 50;

   }
   public void handlebutton100()
   {
    gamestatus.player1HP = 100;
    gamestatus.player2HP = 100;

   }
   public void handlebutton150()
   {
    gamestatus.player1HP = 150;
    gamestatus.player2HP = 150;

   }
}
