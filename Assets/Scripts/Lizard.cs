﻿using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Attacker))]
public class Lizard : MonoBehaviour {
	
	private Animator anim;
	private Attacker attacker;
	
	void Start(){
		anim = GetComponent<Animator>();
		attacker = GetComponent<Attacker>();
	}
	void OnTriggerEnter2D (Collider2D collider){
		GameObject obj = collider.gameObject;
		
		//leave the method if isn't colliding with defender
		if (!obj.GetComponent<Defender>()){
			return;
		}
		anim.SetBool("isAttacking",true);
		attacker.Attack(obj);
	}
	
	
}

