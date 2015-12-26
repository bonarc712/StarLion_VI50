using UnityEngine;
using System.Collections;

public class ObstacleBehaviour : MonoBehaviour {

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnParticleCollision(GameObject other) {
		Debug.Log ("Particle collision!");
		Destroy (this.gameObject);
	}
}
