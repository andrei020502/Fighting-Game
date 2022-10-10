using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class LowPunch : MonoBehaviour
{
   public GameStatus gamestatus;
   public VideoClip p1LowP;
   public VideoClip p2LowP;
   public VideoClip p1LowPMiss;
   public VideoClip p2LowPMiss;
   public VideoPlayer videoPlayer;
   public Idle idle;


   public void LowPunchhandlebutton()
   {
      Debug.Log(gamestatus.playerturn);
      videoPlayer.isLooping = false;
      int damage = attackOrMissed(75,3);
      if (gamestatus.playerturn == 0) {
            videoPlayer.clip = isHitOrMissed(damage, p1LowP, p1LowPMiss);

           Invoke("setToIdle", 2.0f);

           
    }
        else {
        videoPlayer.clip =  isHitOrMissed(damage, p2LowP, p2LowPMiss);
         Invoke("setToIdle", 2.5f);
}

    if (gamestatus.playerturn == 0 ) {
    gamestatus.player2HP -= damage;
    gamestatus.playerturn = 1;
    }
     else if (gamestatus.playerturn == 1 ) {
    gamestatus.player1HP -= damage;
    gamestatus.playerturn = 0;
    }
        Invoke("MovetoWinner", 4.0f);
    
}
        int attackOrMissed(int accuracy, int damage) {
        int random = UnityEngine.Random.Range(0, 100);

        return random <= accuracy ? damage : 0;

    }
        void setToIdle() {
        idle.setIdle();
       }
    
    VideoClip isHitOrMissed(int damage, VideoClip hit, VideoClip missed) {
    return damage == 0 ? hit : missed;
}
    void MovetoWinner(){
    if (gamestatus.player1HP <= 0){
    SceneManager.LoadScene(3); }
    else if (gamestatus.player2HP <= 0){
    SceneManager.LoadScene(4);}
    }
}
