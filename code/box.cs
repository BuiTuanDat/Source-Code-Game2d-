using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour {
	private Animator hop ;

	// Use this for initialization
	void Start () {
		hop=GetComponent<Animator>();
	}
	void OnCollisionEnter2D(Collision2D nv){
		if (nv.gameObject.tag == "nv") {
            Destroy(gameObject);

		}
	}


	
	// Update is called once per frame
	void Update () {
		
	}
}
