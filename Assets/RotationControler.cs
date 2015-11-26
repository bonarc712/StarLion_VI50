using UnityEngine;
using System.Collections;

public class RotationControler : MonoBehaviour {

	public float xSpeedR = 5;
	public float ySpeedR = 5;
	public float zSpeedR = 5;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate (-Input.GetAxis ("Vertical") * xSpeedR, Input.GetAxis ("Horizontal") * ySpeedR,Input.GetAxis ("Horizontal") * zSpeedR );
	
	}
}
