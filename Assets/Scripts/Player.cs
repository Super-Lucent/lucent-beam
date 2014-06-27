using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public string xAxis;
	public string yAxis;
	public KeyCode glow;

	public float speed;
	public float pullSpeed;
	

	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {

		float x = Input.GetAxis (xAxis);
		float y = Input.GetAxis (yAxis);

		rigidbody2D.velocity = new Vector2 (x, y).normalized * speed;

		if (Input.GetKey(glow)) {

			GameObject go = GameObject.Find ("Collect");

			go.rigidbody2D.AddForce ( (transform.position - go.transform.position).normalized * pullSpeed);
		}


	}

	void OnCollisionEnter2D(Collision2D c) {
	
		if (!c.gameObject.CompareTag ("Wall")) {
						Beam b = GameObject.Find ("Beam").GetComponent<Beam> ();
						b.Hit ();
				}
		
	}
}
