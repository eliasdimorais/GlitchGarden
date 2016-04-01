using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StarDisplay : MonoBehaviour {
	
	#region PRIVATE VARIABLES
	private Text starText;
	private int gnomes = 5;
	private int cactus = 5;
	private int trophies = 5;
	private int graveStones = 5;
	private int stars = 100;
	#endregion
	
	#region PUBLIC VARIABLES
	public enum Status {SUCCESS, FAILURE};
	#endregion
	// Use this for initialization
	void Start () {
		starText = GetComponent<Text>();
		UpdateDisplay();	
	}
	
	public void AddStars(int amount){
		stars += amount;
		UpdateDisplay();
	}
	
	public Status UseStars(int amount){
		if( stars >= amount){
			stars -= amount;
			UpdateDisplay();
			return Status.SUCCESS;
		}else{
			return Status.FAILURE;
		}
	}
	
	void UpdateDisplay(){
		starText.text = stars.ToString();
	}
	
}
