using System.Collections;
using System.Collections.Generic;
using CnControls;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour {

	// Use this for initialization
	//Atualização 2.0 = moverCenario na vdd serve para fizer se move lento ou rapido.
	public Text pontos;
	private int ipontos;
	public static bool moverCenario;
	private Rigidbody2D playerRB;
	private SpriteRenderer sprite;
	void Start () {
		playerRB = GetComponent<Rigidbody2D>();
		sprite = GetComponent<SpriteRenderer> ();
		moverCenario = false;
		ipontos = 0;
		pontos.text = ipontos.ToString();
	}
	
	// Update is called once per frame
	void Update () {


		Vector2 movement;
		//player.transform.position = movement;
		if (CnInputManager.GetAxis ("Horizontal") > 0) {
			transform.rotation = Quaternion.Euler (0, 0, CnInputManager.GetAxis ("Vertical") * 75);
			sprite.flipX = false;
		} else if (CnInputManager.GetAxis ("Horizontal") < 0) {
			transform.rotation = Quaternion.Euler (0, 0, CnInputManager.GetAxis ("Vertical") * -75);
			sprite.flipX = true;
		} 
			
		if (playerRB.position.x >= 2.00f && CnInputManager.GetAxis("Horizontal") >=0) {
			
			movement = new Vector2(0, CnInputManager.GetAxis("Vertical")*2);
			moverCenario = true;


		}else if(playerRB.position.x <= -8f && CnInputManager.GetAxis("Horizontal") <=0){
			movement = new Vector2(0, CnInputManager.GetAxis("Vertical")*2);
			moverCenario = true;
		
		} else {
			movement = new Vector2(CnInputManager.GetAxis("Horizontal"),CnInputManager.GetAxis("Vertical")*2f);
			moverCenario = false;

		}

		if (transform.position.y >= 5.00 && CnInputManager.GetAxis("Vertical")>0 || transform.position.y <= -4.5f && CnInputManager.GetAxis("Vertical")<0) {
			movement.y = 0;
		}

		playerRB.velocity = movement*4;

		//print (movement);
	}


	void OnCollisionEnter2D(Collision2D colisao) {
		if (colisao.gameObject.tag == "bom") {
			ipontos++;
			Destroy (colisao.gameObject);
			pontos.text = ipontos.ToString();
		} else if (colisao.gameObject.tag == "ruim") {
			ipontos--;
			Destroy (colisao.gameObject);
			pontos.text = ipontos.ToString();
		}
	}
}
