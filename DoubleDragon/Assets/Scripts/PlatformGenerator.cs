﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour {

	public GameObject thePlatform;
	
	public Transform generationPoint;

	public float distanceBetween;
	
	private float platformWidth;


	// Use this for initialization
	void Start () {
				platformWidth = thePlatform.GetComponent<BoxCollider2D> ().size.x;
	}
	
	// Update is called once per frame
	void Update () {
	transform.position = new Vector3 (transform.position.x + platformWidth + distanceBetween, transform.position.y, transform.position.z);
	
	Instantiate (thePlatform, transform.position, transform.rotation);
	}
}
