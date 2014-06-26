using UnityEngine;
using System.Collections;

public class Glow : MonoBehaviour {

	public AnimationCurve pulseCurve;
	public float pulseTime = 1.0f;
	private float pulse = 0.0f;
	private bool ping = true;

	private float width;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
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

		transform.localScale = new Vector2 (width, width);


	}
}
