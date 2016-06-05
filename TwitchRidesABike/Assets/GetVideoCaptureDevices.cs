using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour {
	// Gets the list of devices and prints them to the console.
	void Start() {
		WebCamDevice[] devices = WebCamTexture.devices;
		for( var i = 0 ; i < devices.Length ; i++ )
			Debug.Log(devices[i].name);        
	}
}