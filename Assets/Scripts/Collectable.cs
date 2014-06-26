using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour {


	public void Collected() {

		audio.Play ();

		Vector3 oldPos = transform.position;

		while ((transform.position - oldPos).magnitude < 2.0f) { //make sure it is a bit away from where it was
			transform.position = new Vector2 (Random.Range (-8, 8), Random.Range (-3, 5));
		}

	}
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
