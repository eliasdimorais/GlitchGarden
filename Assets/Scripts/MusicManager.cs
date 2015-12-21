using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {
	#region Public Variables
	public AudioClip[] levelMusicChangeArray;
	#endregion
	
	#region Private Variables 
	private AudioSource audioSource;
	#endregion
	
	void Awake () {
		DontDestroyOnLoad(gameObject);
		Debug.Log ("Dont destroy on load: " + name);		
	}
	
	void Start(){
		audioSource = GetComponent<AudioSource>();
	}
	
	void OnLevelWasLoaded(int level){
		AudioClip thisLevelMusic = levelMusicChangeArray[level];
		Debug.Log("Music player loaded level " + levelMusicChangeArray[level]);
		if(thisLevelMusic){
			audioSource.clip = thisLevelMusic;
			audioSource.loop = true;
			audioSource.Play();
		}
	}
}
