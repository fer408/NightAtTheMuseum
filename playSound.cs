using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSound : MonoBehaviour {

	public GameObject audioObject;
	public AudioClip soundClip;

	
	// Update is called once per frame
	void OnButtonClicked() {
			audioObject.GetComponent<AudioSource>().clip = soundClip;
	}
}
