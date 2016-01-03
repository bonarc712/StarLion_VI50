using UnityEngine;
using System.Collections;

public class MoveUniverse : MonoBehaviour {
	
	public float speed = 0;
	public float acceleration = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		acceleration = Input.GetAxis("Power");
		speed += acceleration * Time.deltaTime;
		transform.Translate(new Vector3(0, speed, 0));

	}
}
