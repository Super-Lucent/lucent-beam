using UnityEngine;
using System.Collections;

public class Beam : MonoBehaviour {

	public GameObject player1;
	public GameObject player2;

	private LineRenderer lr;

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

	
	}
}
