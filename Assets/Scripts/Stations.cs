using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stations : MonoBehaviour {

	//audio clips for each station
	public AudioClip headsetAudio;
	public AudioClip trackerAudio;
	public AudioClip controllerAudio;
	public AudioClip lighthouseAudio;
	public AudioClip viveportAudio;

	//info displays for each station
	public GameObject headsetDisplay;
	public GameObject controllerDisplay;
	public GameObject trackerDisplay;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void activateDisplay(GvrAudioSource audioSource, AudioClip audio, GameObject display)
	{
		audioSource.cl

	}
}
