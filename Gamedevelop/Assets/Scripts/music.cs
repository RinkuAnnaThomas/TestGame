using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class music : MonoBehaviour {

	public Slider volume;
	public AudioSource myVolume;
	void Update()
	{
		myVolume.volume = volume.value;
	}
}
