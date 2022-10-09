using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameLive : MonoBehaviour
{
   public TMPro.TextMeshProUGUI player1Name;
   public TMPro.TextMeshProUGUI player2Name;
   public GameStatus gamestatus;
   
    
    void Start()
    {
        player1Name.text = gamestatus.player1Name;  
        player2Name.text = gamestatus.player2Name;
        Debug.Log(gamestatus.player1Name);
    }


}