using UnityEngine;
using System.Collections;

public class AsteroideBehaviour : ObstacleBehaviour {

	private GameObject asteroid;
	public float speed = 2;

	// Use this for initialization
	void Start () {
		asteroid = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 anglesToFollow = CinematicMovementManager.GetCurrentAngles();
		//Debug.Log (anglesToFollow.x);
		asteroid.transform.Translate (0, speed, 0);
		//asteroid.transform.Translate (-Mathf.Cos (anglesToFollow.x) * speed, 
		//                              -Mathf.Cos (anglesToFollow.y) * speed,
		//                              -Mathf.Cos (anglesToFollow.z) * speed);
		Debug.Log("Current position : X  = " + asteroid.transform.localPosition.x + 
		          ", Y  = " + asteroid.transform.localPosition.y +
		          ", Z  = " + asteroid.transform.localPosition.z);
		float distanceToCenter = Mathf.Sqrt (Mathf.Pow (asteroid.transform.localPosition.x, 2.0f)
		                                     + Mathf.Pow (asteroid.transform.localPosition.y, 2.0f)
		                                     + Mathf.Pow (asteroid.transform.localPosition.z, 2.0f));
		if (distanceToCenter > 55) {
			Destroy(this.gameObject);
		}
	}
}
