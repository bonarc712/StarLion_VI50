using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class AsteroideManager : MonoBehaviour {

	private static GameObject universe;
	private static List<Vector3> asteroidPositions;

	// Use this for initialization
	void Start () {
		universe = this.gameObject;
		asteroidPositions = new List<Vector3>();
	}
	
	// Update is called once per frame
	void Update () {
	}

	public static List<Vector3> GetCurrentAsteroidPositions() {
		asteroidPositions.Clear();
		foreach (Transform asteroid in universe.transform) {
			asteroidPositions.Add(new Vector3(asteroid.transform.position.x,
			                      asteroid.transform.position.y,
			                      asteroid.transform.position.z));
		}
		return asteroidPositions;
	}
}
