using UnityEngine;
using System.Collections;

public class CinematicMovementManager : MonoBehaviour {

	public GameObject spaceship;

	private static Vector3 currentAngles;

	// Use this for initialization
	void Start () {
		currentAngles = new Vector3 (270, 90, 0);
	}
	
	// Update is called once per frame
	void Update () {
		//currentAngles = spaceship.transform.rotation;
		currentAngles = spaceship.transform.eulerAngles;
		//spaceship.transform.eulerAngles.
		Debug.Log("Current rotation spaceship : X axis = " + spaceship.transform.rotation.x + 
		          ", Y axis = " + spaceship.transform.rotation.y +
		          ", Z axis = " + spaceship.transform.rotation.z);
	}

	public static Vector3 GetCurrentAngles() {
		return currentAngles;
	}
}
