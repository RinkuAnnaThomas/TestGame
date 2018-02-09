using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class music1 : MonoBehaviour {


	
	public Slider volumes;
	public AudioSource myVolumes;
	void Update () {
		myVolumes.volume = volumes.value;
		
	}
}
