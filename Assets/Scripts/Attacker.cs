using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody2D))]
public class Attacker : MonoBehaviour {

	//[Range (-1.0f, 1.5f)]public float currentSpeed;
	private float currentSpeed;
	private GameObject currentTarget;
	private Animator animator;
	
	void Start () {
//		Rigidbody2D myRigidBody = gameObject.AddComponent<Rigidbody2D>();
//		myRigidBody.isKinematic = true;
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * currentSpeed * Time.deltaTime);
		if(!currentTarget){
			animator.SetBool("isAttacking", false);
		}
	}

	void OnTriggerEnter2D(){
		Debug.Log (name + "  trigger Enter");
	}
	
	public void SetSpeed (float speed){
		currentSpeed = speed;
	}
	//Called from the Animator at time of actual blow
	public void StrikerCurrentTag(float damage){
		if(currentTarget){
			Health health = currentTarget.GetComponent<Health>();
			if (health){
				health.DealDamage(damage);
			}
		}	
	}
	
	public void Attack(GameObject obj){
		currentTarget = obj;
	}
}
