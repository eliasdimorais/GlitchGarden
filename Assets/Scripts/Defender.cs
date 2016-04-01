using UnityEngine;
using System.Collections;

public class Defender : MonoBehaviour {
	
	public int starCost = 100;
	private StarDisplay starDisplay;
	// Just using for tagging 
	void Start(){
		starDisplay = GameObject.FindObjectOfType<StarDisplay>();
			
	}
	void Update (){
	
	}
	
	public void AddStars (int amount){
		starDisplay.AddStars(amount);
	}
}
