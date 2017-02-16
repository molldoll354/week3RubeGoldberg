using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ending : MonoBehaviour {
	public GameObject rudeText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(){
		rudeText.SetActive (true);
	}
}
