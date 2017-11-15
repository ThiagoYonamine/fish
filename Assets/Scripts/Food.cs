using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

public class Food : MonoBehaviour {

	float posx;
	float posy;
	float posz;
	void Start(){
		posx = transform.position.x;
		posy = transform.position.y;
		posz = transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		posx -= 0.02f;

		float vel = (CnInputManager.GetAxis ("Horizontal") / 10);
		if (vel >= 0) {
			posx -= vel/2;
		} else {

			posx += 0.005f;
		}
		transform.position = new Vector3 (posx, posy, posz); 
	}
}
