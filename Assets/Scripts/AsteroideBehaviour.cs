using UnityEngine;
using System.Collections;

public class AsteroideBehaviour : ObstacleBehaviour {

	private GameObject asteroid;
	public float speed = 2;
	public Vector3 rotationVector;

	// Use this for initialization
	void Start () {
		asteroid = this.gameObject;
		int x = Random.Range (-3, 3);
		int y = Random.Range (-3, 3);
		int z = Random.Range (-3, 3);
		rotationVector = new Vector3 (x, y, z);
	}
	
	// Update is called once per frame
	void Update () {
		asteroid.transform.Rotate (rotationVector);
		Vector3 anglesToFollow = CinematicMovementManager.GetCurrentAngles();
		//Debug.Log (anglesToFollow.x);
		//asteroid.transform.Translate (0, speed, 0);
		//asteroid.transform.Translate (-Mathf.Cos (anglesToFollow.x) * speed, 
		//                              -Mathf.Cos (anglesToFollow.y) * speed,
		//                              -Mathf.Cos (anglesToFollow.z) * speed);
		Debug.Log("Current position : X  = " + asteroid.transform.position.x + 
		          ", Y  = " + asteroid.transform.position.y +
		          ", Z  = " + asteroid.transform.position.z);
		float distanceToCenter = Mathf.Sqrt (Mathf.Pow (asteroid.transform.position.x, 2.0f)
		                                     + Mathf.Pow (asteroid.transform.position.y, 2.0f)
		                                     + Mathf.Pow (asteroid.transform.position.z, 2.0f));
		Debug.Log ("Distance to center : " + distanceToCenter);
		if (distanceToCenter > 700) {
			Destroy(this.gameObject);
		}
	}
}
