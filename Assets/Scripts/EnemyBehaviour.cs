using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour {

	public float speed = 0.5f; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3 (0, speed, 0));
		float distanceToCenter = Mathf.Sqrt (Mathf.Pow (transform.position.x, 2.0f)
		                                     + Mathf.Pow (transform.position.y, 2.0f)
		                                     + Mathf.Pow (transform.position.z, 2.0f));
		Debug.Log ("Distance to center : " + distanceToCenter);
		if (distanceToCenter > 700) {
			Destroy(this.gameObject);
		}
		
	}
	void OnParticleCollision(GameObject other) {
		Destroy (this.gameObject);
	}
}
