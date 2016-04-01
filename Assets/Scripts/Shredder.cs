using UnityEngine;
using System.Collections;

public class Shredder : MonoBehaviour {
	private LevelManager loseCondition;

	private int number = 0;

	void Start () {
		loseCondition = GameObject.FindObjectOfType<LevelManager>();
	}

	void OnTriggerEnter2D(Collider2D collider){
		Destroy(collider.gameObject);
		number++;
		if (number >= 3){
			loseCondition.LoadLevel("03Lose");
		}
	}
}
