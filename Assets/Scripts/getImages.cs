using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class getImages : MonoBehaviour {
	// The output of the image
	public Image img;

	// The source image
	private string url = "http://www.hazteveg.com/img/icons/food/strawberry-icon.png";

	IEnumerator Start() {
		WWW www = new WWW(url);
		yield return www;
		// Create a texture in DXT1 format
		Texture2D texture = new Texture2D(www.texture.width, www.texture.height, TextureFormat.DXT1, false);
		// assign the downloaded image to sprite
		www.LoadImageIntoTexture(texture);
		Rect rec = new Rect(0, 0, texture.width, texture.height);
		Sprite spriteToUse = Sprite.Create(texture,rec,new Vector2(0.5f,0.5f),100);
		img.sprite = spriteToUse;
		www.Dispose ();
		www = null;
	}

}
