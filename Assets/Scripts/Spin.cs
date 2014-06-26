using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {

	public float rotationSpeedX,
				 rotationSpeedY,
				 rotationSpeedZ;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate (rotationSpeedX * Time.deltaTime, rotationSpeedY * Time.deltaTime, rotationSpeedZ * Time.deltaTime);
	
	}
}
