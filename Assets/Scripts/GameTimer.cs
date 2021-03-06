﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameTimer : MonoBehaviour {

	public float levelSeconds = 100;
	private Slider slider;
	private AudioSource audioSource;
	private LevelManager levelManager;
	private bool isEndOfLevel = false;
	private GameObject winLabel;
	
	void Start () {
		slider = GetComponent<Slider>();
		audioSource = GetComponent<AudioSource>();
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		FindYouWin();
		winLabel.SetActive(false);
		
	}
	
	void FindYouWin(){
		winLabel = GameObject.Find("You Win");
		if(!winLabel){
			Debug.LogWarning("Please create you win object");
		}
	}
	
	// Update is called once per frame
	void Update () {
		slider.value = 	Time.timeSinceLevelLoad/levelSeconds;
		bool timeIsUp = (Time.timeSinceLevelLoad >= levelSeconds);
		if ( timeIsUp && !isEndOfLevel){
			HandleWinCondition();
		}
	}
	void HandleWinCondition(){
		DestroyAllTaggedObjects();
		audioSource.Play ();
		winLabel.SetActive (true);
		Invoke ("LoadNextLevel", audioSource.clip.length);
		isEndOfLevel = true;
		
	}
	void DestroyAllTaggedObjects(){
		GameObject[] taggedObjectArray = GameObject.FindGameObjectsWithTag ("DestroyOnWin");
		
		foreach(GameObject taggedObject in taggedObjectArray){
			Destroy(taggedObject);
		}
	}
	void LoadNextLevel(){
		levelManager.LoadNextLevel();
	}
}
