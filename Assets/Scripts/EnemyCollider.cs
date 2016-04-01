using UnityEngine;
using System.Collections;

public class EnemyCollider : MonoBehaviour {

	LevelManager levelManager;
	
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter2D(){
		levelManager.LoadLevel("03Lose");
	}
	
}
