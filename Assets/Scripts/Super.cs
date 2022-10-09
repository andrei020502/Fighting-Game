using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Super : MonoBehaviour
{
     public GameStatus gamestatus;
     public VideoPlayer videoPlayer;
     public VideoClip p1Super;
     public VideoClip p2Super;
     public VideoClip p1SuperMiss;
     public VideoClip p2SuperMiss;
     public Idle idle;

   public void Superhandlebutton()
  {
      Debug.Log(gamestatus.playerturn);
      videoPlayer.isLooping = false;
      int damage = attackOrMissed(90,25);
      if (gamestatus.playerturn == 0) {
            videoPlayer.clip = isHitOrMissed(damage, p1Super, p1SuperMiss);
            Invoke("setToIdle", 3.0f);
    }
        else {
        videoPlayer.clip = isHitOrMissed(damage, p2Super, p2SuperMiss);
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
