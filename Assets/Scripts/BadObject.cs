using UnityEngine;
using System.Collections;

public class BadObject : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {

		rigidbody2D.velocity = new Vector2 (Random.Range (1, 10), Random.Range (1, 10)).normalized * speed;
	
	}
	
	// Update is called once per frame
	void Update () {

		rigidbody2D.velocity = rigidbody2D.velocity.normalized * speed;
	
	}

	void OnCollisionEnter2D(Collision2D c) {


	}

	void OnTriggerEnter2D(Collider2D c) {


	}
}
