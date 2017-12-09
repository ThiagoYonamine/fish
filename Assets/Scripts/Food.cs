using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

public class Food : MonoBehaviour {

	private Rigidbody2D FoodRB;

	void Start(){
		FoodRB = GetComponent<Rigidbody2D>();
	}
	// Update is called once per frame
	void Update () {
		if (transform.position.x < 15) {
			
			FoodRB.velocity = new Vector2 (CnInputManager.GetAxis("Horizontal")*-10, 0);

			if (transform.position.x <= -15) {
				//print ("destroy");
				Destroy (gameObject);
			}
		}

	}
}
