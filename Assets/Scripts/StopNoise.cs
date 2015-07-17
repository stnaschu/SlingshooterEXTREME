using UnityEngine;
using System.Collections;

public class StopNoise : MonoBehaviour {

	private float TimeBeforeNoiseStops;
	void Start () {
	
		var sound = this.GetComponent<AudioSource>();
		TimeBeforeNoiseStops = sound.clip.length;
	}
	
	// Update is called once per frame
	void Update () {

		TimeBeforeNoiseStops -= Time.deltaTime;
		if(TimeBeforeNoiseStops <= 0f)
		   Destroy (this.gameObject);

	}
}
