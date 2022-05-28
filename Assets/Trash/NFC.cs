/*using System.Collections;
using System.Collections.Generic;
using System;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class NFC : MonoBehaviour {

	public string tagID;
	public Text tag_output_text;
	public bool tagFound = false;
	//SpriteRenderer renderingn;

	private AndroidJavaObject mActivity;
	private AndroidJavaObject mIntent;
	private string sAction;
	public GameObject Green;
	public GameObject Yellow;
	public GameObject Red;
	public GameObject Button;
	//public GameObject popupobjects;



	void Start() {
		tag_output_text.text = "Scan a NFC tag to make the cube disappear...";
		//renderingn = GetComponent<SpriteRenderer>();
		//renderingn.color = Color.HSVToRGB(0.2f, 1, 1);
	}

	void Update() {
		if (Application.platform == RuntimePlatform.Android) {
			if (!tagFound) {
				try {
					// Create new NFC Android object
					mActivity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity"); // Activities open apps
					mIntent = mActivity.Call<AndroidJavaObject>("getIntent");
					sAction = mIntent.Call<String>("getAction"); // resulte are returned in the Intent object
					if (sAction == "android.nfc.action.NDEF_DISCOVERED") {
						Debug.Log("Tag of type NDEF");
					}
					else if (sAction == "android.nfc.action.TECH_DISCOVERED") {
						Debug.Log("TAG DISCOVERED");
						// Get ID of tag
						AndroidJavaObject mNdefMessage = mIntent.Call<AndroidJavaObject>("getParcelableExtra", "android.nfc.extra.TAG");
						if (mNdefMessage != null) {
							byte[] payLoad = mNdefMessage.Call<byte[]>("getId");
							string text = System.Convert.ToBase64String(payLoad);
							tag_output_text.text += "This is your tag text: " + text;
							
							tagID = text;
						}
						else {
							tag_output_text.text = "No ID found !";
						}
						tagFound = true;
						StartCoroutine(Count());

						// How to read multiple tags maybe with this line mIntent.Call("removeExtra", "android.nfc.extra.TAG");
						return;
					}
					else if (sAction == "android.nfc.action.TAG_DISCOVERED") {
						Debug.Log("This type of tag is not supported !");
					}
					else {
						tag_output_text.text = "Scan a NFC tag to make the cube disappear...";
						return;
					}
				}
				catch (Exception ex) {
					string text = ex.Message;
					tag_output_text.text = text;
				}
			}
		}
	}

	IEnumerator Count()
    {
		yield return new WaitForSeconds(8);
		tagFound = false;
		Green.SetActive(false);
		Yellow.SetActive(false);
		Red.SetActive(false);
		
	}



    public void FixedUpdate()
    {
       
		
		if (tagID == "8bh2HQ==")
        {
			Green.SetActive (true);
			Yellow.SetActive (false);
			Red.SetActive (false);
			//Button.SetActive(true);
			//renderingn.color = Color.HSVToRGB(0.5f, 1, 1);
			//Instantiate(popupobjects, transform.position, transform.rotation);
		}

		if (tagID == "Ef9vHQ==")
        {
			Yellow.SetActive (true);
			Green.SetActive (false);
			Red.SetActive(false);
			//Button.SetActive(true);

			//renderingn.color = Color.HSVToRGB(0.1f, 1, 1);
			//Instantiate(popupobjects, transform.position, transform.rotation);
		}

		if (tagID == "AckwHQ==")
        {
			Red.SetActive (true);
			Green.SetActive(false);
			Yellow.SetActive (false);
			//Button.SetActive(true);

			//renderingn.color = Color.HSVToRGB(0.9f, 1, 1);
			//Instantiate(popupobjects, transform.position, transform.rotation);
		}

		


	}
	/*public void Assec()
    {
		Red.SetActive(false);
		Green.SetActive(false);
		Yellow.SetActive(false);
		Button.SetActive(false);
	}

}
*/