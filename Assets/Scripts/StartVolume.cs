using UnityEngine;
using System.Collections;

public class StartVolume : MonoBehaviour {

	private MusicManager musicManager;
	// Use this for initialization
	void Start () {
		musicManager = GameObject.FindObjectOfType<MusicManager>();
		if(musicManager){
			float volume = PlayerPrefsManager.GetMasterVolume();
			musicManager.SetVolume(volume);
			Debug.Log("Found music manager "+ musicManager);
		}else{
			Debug.LogWarning(" Not Found music manager in the Start Scene "+ musicManager);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
