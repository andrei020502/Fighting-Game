using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour

{
    public TMPro.TextMeshProUGUI HP1inText;
    public TMPro.TextMeshProUGUI HP2inText;
    public GameStatus gamestatus;

   
     void Update()
     {
        HP1inText.text = gamestatus.player1HP.ToString();
        HP2inText.text = gamestatus.player2HP.ToString();
     }
}

