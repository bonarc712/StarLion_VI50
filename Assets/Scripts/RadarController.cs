using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RadarController : MonoBehaviour {

	public Transform radarObjectPrefab;
	List<GameObject> radarObjects;
	private int counter;
	public int maxCounterValue = 50;

	// Use this for initialization
	void Start () {
		radarObjects = new List<GameObject> ();
		counter = maxCounterValue;
	}
	
	// Update is called once per frame
	void Update () {
		if (counter == maxCounterValue) {
			foreach (GameObject radarObj in radarObjects) {
				Destroy (radarObj);
			}
			radarObjects.Clear ();
			List<Vector3> currentAsteroidPositions = AsteroideManager.GetCurrentAsteroidPositions ();
			foreach (Vector3 position in currentAsteroidPositions) {
				Transform newObject = GameObject.Instantiate (radarObjectPrefab, new Vector3 (this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z), Quaternion.identity) as Transform;
				radarObjects.Add(newObject.gameObject);
			}
			counter = 0;
		} else {
			counter++;
		}
	}
}
