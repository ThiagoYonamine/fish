using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

public class Gerador : MonoBehaviour {
	public Rigidbody2D[] rigidBodyComida;

	private int timer;

	// Use this for initialization
	void Start () {
		timer = 0;
	}

	void FixedUpdate () {
		if(CnInputManager.GetAxis("Horizontal") >0)
			timer++;
		
		if(timer >=100){
			Rigidbody2D instanceComida;
			int randComida =  Random.Range (0, rigidBodyComida.Length);
			string comida = "comida" + randComida.ToString ();

			while (PlayerPrefs.GetInt(comida) == 0) {
				randComida =  Random.Range (0, rigidBodyComida.Length);
				comida = "comida" + randComida.ToString ();
			}
			print (comida);
			print (PlayerPrefs.GetInt (comida));

			instanceComida = Instantiate (rigidBodyComida[randComida]) as Rigidbody2D;
			float randY = Random.Range (-3, 3);
			Vector2 positionRespaw = new Vector2 (10, randY);
			instanceComida.position = positionRespaw;
			//instanceComida.velocity = new Vector2 (-1, 0);
			//instanceComida.AddForce (new Vector3 (-1, 0, 0));
			timer = 0;
		}
	}
}