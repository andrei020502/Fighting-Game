using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayagainorExit : MonoBehaviour
{
    
    public void playagain()
    {
        SceneManager.LoadScene(1);
    }

  
    public void Exit()
    {
     Application.Quit();
    }
}
