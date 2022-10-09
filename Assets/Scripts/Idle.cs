using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class Idle : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public VideoClip idleclip;

    public void setIdle()
    {
        videoPlayer.clip = idleclip;
        videoPlayer.isLooping = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
