﻿using UnityEngine;
using System.Collections;

public class CoreScript : MonoBehaviour {

	public GameObject speedboost;
	//public Object slowboost;
	// Use this for initialization
	void Start () {
		
		InvokeRepeating("createObject", 1.0f, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {

	}
	void createObject(){
		//Vector3 nextPosition = GameObject.Find("character").transform.position;
		//Instantiate (speedboost, nextPosition - new Vector3 (10,10,0),new Quaternion(0,0,0,0));
		float x = Random.Range(0,100);
		float y = Random.Range(0,100);
		speedboost = Instantiate(
			Resources.Load("boost_speed"),
			GameObject.Find("character").transform.position + new Vector3 (100 + x, y,0) ,
			new Quaternion(0,0,0,0)) as GameObject;
		Destroy (speedboost, 10.0f);
	}
}
