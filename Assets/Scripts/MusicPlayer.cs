using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
	static MusicPlayer instance = null;
	
	public AudioClip menuScene;
	public AudioClip gameScene;
	public AudioClip endScene;
	
	private AudioSource music;
	
	void Start () {
		if (instance != null && instance != this) {
			Destroy (gameObject);
			print ("Duplicate music player self-destructing!");
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
			music = GetComponent<AudioSource>();
			music.clip = menuScene;
			music.loop = true;
			music.Play();
		}
		
	}
	void OnLevelWasLoaded(int level){
		if (instance == this){
			Debug.Log("Music player loaded level " + level);
			music.Stop();
			if(level == 0){
				music.clip = menuScene;	
			}
			else if(level == 1){
				music.clip = gameScene;	
			}
			else if(level == 2){
				music.clip = endScene;	
			}
			music.loop = true;
			music.Play();
		}
	}
}
