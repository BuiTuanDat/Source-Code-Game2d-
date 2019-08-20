using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vang : MonoBehaviour {
	private Animator coin ;
	float Timer;

	// Use this for initialization
	void Start () {
		coin=GetComponent<Animator>();
		Timer = Time.time;
	}
	void OnCollisionEnter2D(Collision2D nv){
		if (nv.gameObject.tag == "nv") {
			coin.SetBool ("anvang", true);

		}
			
		
	}

	// Update is called once per frame
	void Update () {
		
	}
}
