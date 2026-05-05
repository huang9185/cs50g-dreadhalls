using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		// "Submit" is a keyward for either enter or return
		// specifically an integer, not a boolean
		if (Input.GetAxis("Submit") == 1) {
			SceneManager.LoadScene("Play");
		}
	}
}
