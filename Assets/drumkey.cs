﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drumkey : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        GetComponent<AudioSource>().Play();

    }
}
