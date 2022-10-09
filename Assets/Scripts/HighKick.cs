using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class HighKick : MonoBehaviour
{
      public GameStatus gamestatus;
      public VideoPlayer videoPlayer;
      public VideoClip p1HighK;
      public VideoClip p2HighK;
      public VideoClip p1HighKMiss;
      public VideoClip p2HighKMiss;
      public Idle idle;
   
   public void HighKickhandlebutton()
   {
      Debug.Log(gamestatus.playerturn);
      videoPlayer.isLooping = false;
      int damage = attackOrMissed(45,12);
      if (gamestatus.playerturn == 0) {
          videoPlayer.clip = isHitOrMissed(damage, p1HighK, p1HighKMiss);
            videoPlayer.clip = p1HighK;
            Invoke("setToIdle", 3.0f);
    }
        else {
        videoPlayer.clip = isHitOrMissed(damage, p2HighK, p2HighKMiss);
        Invoke("setToIdle", 3.0f);
        }
      
    if (gamestatus.playerturn == 0 ) {
    gamestatus.player2HP -= damage;
    gamestatus.playerturn = 1;
    Debug.Log("50");
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
