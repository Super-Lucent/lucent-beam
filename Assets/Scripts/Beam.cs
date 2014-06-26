using UnityEngine;
using System.Collections;
using Holoville.HOTween;

public class Beam : MonoBehaviour {

	public GameObject player1;
	public GameObject player2;

	public AnimationCurve hitColourCurve;
	public GameObject hitColourQuad;
	private float hitColourTime;

	private LineRenderer lr;

	public float hitRecoverTime;

	private float hitTime;

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

		if (hitTime > 0.0f) {
			hitTime -= Time.deltaTime;
			lr.renderer.enabled = false;
		} else {
			lr.renderer.enabled = true;
			CollectItems ();
		}

		if (hitColourTime > 0.0f) { 

			hitColourTime -= Time.deltaTime;
			Color c = hitColourQuad.renderer.material.color;
			hitColourQuad.renderer.material.color = new Color(c.r, c.g, c.b,hitColourCurve.Evaluate(hitColourTime));

		}


		
	}

	public void Hit() {

		if (hitTime <= 0.0f) {
			hitTime = hitRecoverTime;
			hitColourTime = 1.0f;
			audio.Play ();

			TweenParms parms = new TweenParms();
			// UnityScript

			parms.Prop("position", Vector3.zero); // Position tween

			HOTween.Shake(Camera.main.transform, 1.5f, parms, 1.5f, 0.12f );
	
		}
	
	}

	private void CollectItems() {
		Vector3 direction = player2.transform.position - player1.transform.position;
		
		RaycastHit2D hit = Physics2D.Raycast (player1.transform.position, direction, direction.magnitude, 1 <<LayerMask.NameToLayer("Collect"));
		
		Debug.DrawRay ( player1.transform.position, direction);
		
		if (hit.collider != null) {
			Debug.Log ("hit " + hit.transform.gameObject.name);
			hit.collider.GetComponent<Collectable>().Collected ();
		}
	}

}
