using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class LowKick : MonoBehaviour
{
     public GameStatus gamestatus;
   public VideoClip p1LowK;
   public VideoClip p2LowK;
   public VideoClip p1LowKMiss;
   public VideoClip p2LowKMiss;
   public VideoPlayer videoPlayer;
   public Idle idle;

   public void LowKickhandlebutton()
   {
      Debug.Log(gamestatus.playerturn);
      videoPlayer.isLooping = false;
      int damage = attackOrMissed(65,6);
      if (gamestatus.playerturn == 0) {
            videoPlayer.clip = isHitOrMissed(damage, p1LowK, p1LowKMiss);
            Invoke("setToIdle", 3.0f);
    }
        else {
        videoPlayer.clip = isHitOrMissed(damage, p2LowK, p2LowKMiss);
        Invoke("setToIdle", 3.0f);
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
