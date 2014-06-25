using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public string xAxis;
	public string yAxis;

	public float speed;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {

		float x = Input.GetAxis (xAxis);
		float y = Input.GetAxis (yAxis);

		rigidbody2D.velocity = new Vector2 (x, y).normalized * speed;

		
	
	}
}
