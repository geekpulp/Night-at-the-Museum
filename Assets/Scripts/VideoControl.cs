using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoControl : MonoBehaviour {

    private UnityEngine.Video.VideoPlayer videoPlayer;
    public GameObject videoOrbToPlay;

    [SerializeField]
    //private AudioSource audioSource;

    void Start () {
        videoPlayer = GetComponent<UnityEngine.Video.VideoPlayer> ();


        //if (videoPlayer.clip != null) 
        //{
        //    videoPlayer.EnableAudioTrack (0, true);
        //    videoPlayer.SetTargetAudioSource(0, audioSource);
        //}
    }

    //Check if input keys have been pressed and call methods accordingly.
    void Update(){
        //Play or pause the video.
        if (Input.GetKeyDown ("space")) 
        {
            if (videoPlayer.isPlaying)
                videoPlayer.Pause ();
            else
                videoPlayer.Play();
                //audioSource.Play();
        }

    }

    public void playpause() {
        if (videoPlayer.isPlaying)
            videoPlayer.Pause();
        else
            videoPlayer.Play();
    }

    public void showplayer(GameObject videoOrbToPlay)
    {
        videoOrbToPlay.SetActive;
    }

}