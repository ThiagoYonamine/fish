using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Login : MonoBehaviour {

	public InputField intxt;

	public void login(){

		string s = intxt.text;
		print (s);

		PlayerPrefs.SetInt ("comida0", s[0]-'0');
		PlayerPrefs.SetInt ("comida1", s[1]-'0');
		PlayerPrefs.SetInt ("comida2", s[2]-'0');
		PlayerPrefs.SetInt ("comida3", s[3]-'0');
		PlayerPrefs.SetInt ("comida4", s[4]-'0');
		SceneManager.LoadScene ("home", LoadSceneMode.Single);
	}


}
