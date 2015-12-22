using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeInOut : MonoBehaviour {
	
	#region Public Variables
	public float fadeInTimeSec;
	#endregion
	
	#region Private Variables
	private Image fadePanel;
	private Color currentColor = Color.black;
	#endregion
	
	void Start () {
		fadePanel = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad < fadeInTimeSec){
			float alphaChange = Time.deltaTime / fadeInTimeSec;
			currentColor.a -= alphaChange;
			fadePanel.color = currentColor;
		}else{
			gameObject.SetActive(false);
		}
	}
}
