﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kickdrumsound : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
            GetComponent<AudioSource>().Play();
	}

}
