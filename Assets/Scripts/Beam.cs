﻿using UnityEngine;
using System.Collections;

public class Beam : MonoBehaviour {

	public GameObject player1;
	public GameObject player2;

	private LineRenderer lr;

	private float width;

	public AnimationCurve pulseCurve;
	public float pulseTime = 1.0f;
	private float pulse = 0.0f;
	private bool ping = true;




	// Use this for initialization
	void Start () {

		lr = GetComponent<LineRenderer> ();
		lr.SetVertexCount (2);

	}
	
	// Update is called once per frame
	void Update () {

		Vector3 p1p = player1.transform.position;
		Vector3 p2p = player2.transform.position;



		lr.SetPosition (0, p1p);
		lr.SetPosition (1, p2p);

		if (ping) { 
			pulse += Time.deltaTime;
			if (pulse >  pulseTime) {
				ping = !ping;
			}
		} else {
			pulse -= Time.deltaTime;
			if (pulse < 0.0f) {
				ping = !ping;
			}

		}

		width = pulseCurve.Evaluate (pulse);

		lr.SetWidth (width, width);
	
	}
}
